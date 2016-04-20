﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Weather
{
    public partial class MainForm : Form
    {
        public WeatherData data;
        private XmlSerializer xs = new XmlSerializer(typeof(WeatherData));

        public MainForm()
        {
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                using (var fs = File.OpenRead("Y:\\norway.xml"))
                {
                    data = (WeatherData)xs.Deserialize(fs);
                }

                SyncState();
            }
            catch (InvalidOperationException)
            {
                // XML error
            }
            catch (Exception)
            {

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
                    if (DateTime.UtcNow > i.From && DateTime.UtcNow < i.To)
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
                        g.DrawString(String.Format("{0}°", t.Temperature.Value),
                            new Font(FontFamily.GenericMonospace, 8, FontStyle.Regular),
                            Brushes.White, PointF.Empty);
                    }
                    Icon i = Icon.FromHandle(b.GetHicon());
                    notifyIcon.Icon = i;
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
