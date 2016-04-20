using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Weather
{
    public partial class MainForm : Form
    {
        const string yrnoBase = "http://www.yr.no/place/{0}/forecast.xml";

        public WeatherData data;
        private WebClient wc = new WebClient();
        private XmlSerializer xs = new XmlSerializer(typeof(WeatherData));

        public MainForm()
        {
            InitializeComponent();
            wc.Headers.Add(HttpRequestHeader.UserAgent, "https://github.com/NattyNarwhal/Weather");
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                //using (var fs = wc.OpenRead(String.Format(yrnoBase, "Norway/Telemark/Sauherad/Gvarv")))
                using (var fs = File.OpenRead("Y:\\norway.xml"))
                {
                    data = (WeatherData)xs.Deserialize(fs);
                }
                SyncState();
            }
            catch (InvalidOperationException)
            {
                FlashError("An error occured parsing the weather data.");
            }
            catch (Exception)
            {
                FlashError("An unknown error occured trying to get the weather data.");
            }
        }

        public void FlashError(string message)
        {
            if (notifyIcon.Icon != null)
            {
                notifyIcon.ShowBalloonTip(10000, "An error occured with fetching the weather",
                    message, ToolTipIcon.Error);
            }
            else
            {
                MessageBox.Show(this, message, "Weather", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SyncState()
        {
            Text = data.Location.ToString();
            creditsToolStripMenuItem.ToolTipText = data.Credit.Link.Text;
            sunLabel.Text = String.Format("The sun will rise at {0} and set at {1}.",
                data.Sun.Rise.ToShortTimeString(), data.Sun.Set.ToShortTimeString());
            lastUpdateLabel.Text = String.Format("Last update: {0}",
                data.Meta.LastUpdate);
            nextUpdateLabel.Text = String.Format("Next update: {0}",
                data.Meta.NextUpdate);

            // forecast
            forecastBox.Items.Clear();
            forecastBox.Groups.Clear();

            var grouped = data.Forecast.Times.GroupBy(x => x.From.Date);
            foreach (var g in grouped)
            {
                var lvg = new ListViewGroup(g.Key.Date.ToShortDateString());
                forecastBox.Groups.Add(lvg);
                foreach (var i in g)
                {
                    var lvi = new ListViewItem();
                    lvi.Group = lvg;
                    if (i.FitsInPeriod(DateTime.UtcNow))
                        lvi.Font = new Font(lvi.Font, FontStyle.Bold);
                    lvi.Text = string.Format("{0} - {1}",
                        i.From.ToShortTimeString(), i.To.ToShortTimeString());
                    lvi.SubItems.Add(i.Symbol.Name);
                    lvi.SubItems.Add(i.Temperature.ToString());
                    lvi.SubItems.Add(i.Precipitation.ToString());
                    lvi.SubItems.Add(i.Wind());
                    lvi.SubItems.Add(i.Pressure.ToString());
                    forecastBox.Items.Add(lvi);
                }
            }

            // current conditions
            var t = data.Forecast.Times.Where(x => DateTime.UtcNow > x.From
                && DateTime.UtcNow < x.To).FirstOrDefault();
            if (t != null)
            {
                //make icons
                using (Bitmap b = new Bitmap(16, 16))
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        var pos = !(t.Temperature.Value < 0);

                        g.FillEllipse(pos ? Brushes.White : Brushes.Black,
                            new Rectangle(0, 0, 15, 15));
                        g.DrawEllipse(pos ? Pens.Black : Pens.White, new Rectangle(0, 0, 15, 15));
                        g.DrawString(String.Format("{0}", Math.Abs(t.Temperature.Value)),
                            new Font(FontFamily.GenericMonospace, 8, FontStyle.Regular),
                            pos ? Brushes.Black : Brushes.White, new Point(-1, 0));
                    }
                    Icon i = Icon.FromHandle(b.GetHicon());
                    notifyIcon.Icon = i;

                    if (TaskbarManager.IsPlatformSupported)
                        TaskbarManager.Instance.SetOverlayIcon(i, t.Temperature.ToString());
                }
                notifyIcon.Text = String.Format("{1}, {0}\r\n{2}\r\n{3}",
                    t.Symbol.Name, t.Temperature, t.Precipitation, t.Wind());
                notifyIcon.Visible = true;
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(data.Credit.Link.Url);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(data.Links.Where(x => x.Id == "overview").FirstOrDefault()?.Url);
        }

        private void hourlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(data.Links.Where(x => x.Id == "hourByHour").FirstOrDefault()?.Url);
        }

        private void longTermToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(data.Links.Where(x => x.Id == "longTermForecast").FirstOrDefault()?.Url);
        }

        private void radarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(data.Links.Where(x => x.Id == "radar").FirstOrDefault()?.Url);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = !Visible;
        }
    }
}
