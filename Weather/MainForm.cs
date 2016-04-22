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
        public string weatherLocation;
        public bool useNotificationIcon;

        public WeatherData data;
        private XmlSerializer xs = new XmlSerializer(typeof(WeatherData));
        private Icon icon; // used for both notify + taskbar overlay

        public MainForm()
        {
            InitializeComponent();
            weatherLocation = Properties.Settings.Default.WeatherLocation;
            useNotificationIcon = Properties.Settings.Default.UseNotificationIcon;

            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                using (var fs = Fetcher.GetStream(weatherLocation))
                {
                    data = (WeatherData)xs.Deserialize(fs);
                }
                SyncState();
            }
            catch (WebException)
            {
                FlashError("An error occured trying to download the weather data.");
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
            MessageBox.Show(this, message, "Weather", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SyncState()
        {
            var adjustedNow = DateTime.UtcNow.AddMinutes
                (data.Location.TimeZone.UTCOffsetMinutes);

            Text = data.Location.ToString();
            creditsToolStripMenuItem.ToolTipText = data.Credit.Link.Text;
            sunLabel.Text = String.Format("The sun will rise at {0} and set at {1}.",
                data.Sun.Rise.ToShortTimeString(), data.Sun.Set.ToShortTimeString());
            lastUpdateLabel.Text = String.Format("Last update: {0}",
                data.Meta.LastUpdate);
            nextUpdateLabel.Text = String.Format("Next update: {0}",
                data.Meta.NextUpdate);

            overviewToolStripMenuItem.Enabled = data.Links.Any(x => x.Id == "overview");
            hourlyToolStripMenuItem.Enabled = data.Links.Any(x => x.Id == "hourByHour");
            longTermToolStripMenuItem.Enabled = data.Links.Any(x => x.Id == "longTermForecast");
            radarToolStripMenuItem.Enabled = data.Links.Any(x => x.Id == "radar");

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
                    // sometimes the site doesn't include the period that
                    // the adjusted date fits in
                    if (i.FitsInPeriod(adjustedNow) ||
                        (i.From.Date == adjustedNow.Date && g.First() == i))
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

            var t = data.GetCurrentForecast();
            if (t != null)
            {
                //make icons
                using (var b = new Bitmap(16, 16))
                {
                    using (var g = Graphics.FromImage(b))
                    {
                        var pos = t.Temperature.Value > 0;
                        var val = Math.Abs(t.Temperature.Value);
                        var font = new Font(FontFamily.GenericMonospace,
                            8, FontStyle.Regular);
                        // i think rectangles are 0-indexed
                        var r = new Rectangle(0, 0, 15, 15);

                        g.FillEllipse(pos ? Brushes.White : Brushes.Black, r);
                        g.DrawEllipse(pos ? Pens.Black : Pens.White, r);
                        g.DrawString(val.ToString(), font, pos ?
                            Brushes.Black : Brushes.White, val > 9 ? 0 : 3, 1);
                    }
                    icon = Icon.FromHandle(b.GetHicon());
                }

                if (useNotificationIcon)
                {
                    notifyIcon.Icon = icon;
                    notifyIcon.Text = String.Format("{1}, {0}\r\n{2}\r\n{3}",
                        t.Symbol.Name, t.Temperature, t.Precipitation, t.Wind());
                    notifyIcon.Visible = true;
                }
                else if (!useNotificationIcon && Visible && TaskbarManager.IsPlatformSupported)
                {
                    try
                    {
                        TaskbarManager.Instance.SetOverlayIcon(icon,
                            data.GetCurrentForecast().Temperature.ToString() ?? "");
                    }
                    catch (InvalidOperationException)
                    {
                        // sometimes we can't get the tray icon...
                    }
                }
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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm()
            {
                WeatherLocation = weatherLocation,
                UseNotificationIcon = useNotificationIcon
            };
            if (sf.ShowDialog(this) == DialogResult.OK)
            {
                weatherLocation = sf.WeatherLocation;
                useNotificationIcon = sf.UseNotificationIcon;
                Properties.Settings.Default.WeatherLocation = weatherLocation;
                Properties.Settings.Default.UseNotificationIcon = useNotificationIcon;
                Properties.Settings.Default.Save();
                RefreshData();
            }
        }

        private void updatePollTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.UtcNow > data.Meta.NextUpdate.AddMinutes
                (-data.Location.TimeZone.UTCOffsetMinutes))
            {
                RefreshData();
            }
        }
    }
}
