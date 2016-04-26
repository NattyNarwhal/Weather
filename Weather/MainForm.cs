﻿using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Weather
{
    public partial class MainForm : Form
    {
        public string weatherLocation;
        public bool useNotificationIcon;
        public bool hourlyForecast;
        public bool descriptiveWind;
        public bool symbolAsWindowIcon;
        public bool symbolAsNotificationIcon;

        public WeatherData data;
        private XmlSerializer xs = new XmlSerializer(typeof(WeatherData));
        private Icon icon; // used for both notify + taskbar overlay

        public MainForm()
        {
            InitializeComponent();
            weatherLocation = Properties.Settings.Default.WeatherLocation;
            useNotificationIcon = Properties.Settings.Default.UseNotificationIcon;
            hourlyForecast = Properties.Settings.Default.Hourly;
            descriptiveWind = Properties.Settings.Default.DescriptiveWind;
            symbolAsNotificationIcon = Properties.Settings.Default.SymbolNotificationIcon;
            symbolAsWindowIcon = Properties.Settings.Default.SymbolWindowIcon;
        }

        public Icon GetSymbolIcon(TabularTimeSymbol ts)
        {
            switch ((SymbolNumber)ts.Number)
            {
                case SymbolNumber.Sunny:
                    return Properties.Resources.Clear;
                case SymbolNumber.Fair:
                case SymbolNumber.PartlyCloudy:
                    return Properties.Resources.Partly;
                case SymbolNumber.Cloudy:
                case SymbolNumber.Fog:
                    return Properties.Resources.Fair;
                case SymbolNumber.Rain:
                case SymbolNumber.Sleet:
                case SymbolNumber.SleetShowers:
                    return Properties.Resources.Rain;
                case SymbolNumber.RainShowers:
                case SymbolNumber.HeavyRain:
                    return Properties.Resources.Showers;
                case SymbolNumber.Snow:
                case SymbolNumber.SnowShowers:
                    return Properties.Resources.Snow;
                case SymbolNumber.RainAndThunder:
                case SymbolNumber.RainAndThunderAlternate:
                case SymbolNumber.RainShowersWithThunder:
                case SymbolNumber.SleetAndThunder:
                case SymbolNumber.SleetShowersAndThunder:
                case SymbolNumber.SnowAndThunder:
                case SymbolNumber.SnowShowersAndThunder:
                    return Properties.Resources.Thunder;
                default: throw new Exception("The symbol number is unknown");
            }
        }

        public void RefreshData()
        {
            try
            {
                using (var fs = Fetcher.GetStream(weatherLocation, hourlyForecast))
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
            sunLabel.Text = message;
            if (notifyIcon.Visible)
                notifyIcon.ShowBalloonTip(0, "Error", message, ToolTipIcon.Error);
            Icon = Properties.Resources.Error;
        }

        public void SyncState()
        {
            var adjustedNow = DateTime.UtcNow.AddMinutes
                (data.Location.TimeZone.UTCOffsetMinutes);

            Text = data.Location.ToString();
            creditLink.Text = data.Credit.Link.Text;

            sunLabel.Text = String.Format("The sun will rise at {0} and set at {1}.",
                data.Sun.Rise.ToShortTimeString(), data.Sun.Set.ToShortTimeString());
            lastUpdateLabel.Text = String.Format("Last update: {0}",
                data.Meta.LastUpdate.AddMinutes
                (-data.Location.TimeZone.UTCOffsetMinutes).ToLocalTime());
            nextUpdateLabel.Text = String.Format("Next update: {0}",
                data.Meta.NextUpdate.AddMinutes
                (-data.Location.TimeZone.UTCOffsetMinutes).ToLocalTime());

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
                    lvi.SubItems.Add(i.Wind(descriptiveWind));
                    lvi.SubItems.Add(i.Pressure.ToString());
                    lvi.Tag = i;
                    forecastBox.Items.Add(lvi);
                }
            }

            var t = data.GetCurrentForecast();
            if (t != null)
            {
                //make icons
                // TODO: refactor this out into sep func
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

                        // HACK: centering is one
                        g.DrawString(val.ToString(), font, pos ?
                            Brushes.Black : Brushes.White, val > 9 ? 0 : 3, 1);
                    }
                    icon = Icon.FromHandle(b.GetHicon());
                }

                Icon = symbolAsWindowIcon ? GetSymbolIcon(t.Symbol) : icon;

                if (useNotificationIcon)
                {
                    notifyIcon.Icon = symbolAsNotificationIcon ?
                        GetSymbolIcon(t.Symbol) : icon;
                    notifyIcon.Text = String.Format("{1}, {0}\r\n{2}\r\n{3}",
                        t.Symbol.Name, t.Temperature, t.Precipitation, t.Wind(descriptiveWind));
                    notifyIcon.Visible = true;
                }
                else if (!useNotificationIcon && Visible && TaskbarManager.IsPlatformSupported)
                {
                    Visible = true;
                    notifyIcon.Visible = false;
                    try
                    {
                        TaskbarManager.Instance.SetOverlayIcon(
                            symbolAsWindowIcon ? icon : GetSymbolIcon(t.Symbol),
                            String.Format("{0}, {1}", t.Temperature, t.Symbol.Name));
                    }
                    catch (InvalidOperationException)
                    {
                        // sometimes we can't get the tray icon...
                    }
                }
            }
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
                UseNotificationIcon = useNotificationIcon,
                Hourly = hourlyForecast,
                DescriptiveWind = descriptiveWind,
                SymbolWindowIcon = symbolAsWindowIcon,
                SymbolNotificationIcon = symbolAsNotificationIcon
            };
            if (sf.ShowDialog(this) == DialogResult.OK)
            {
                weatherLocation = sf.WeatherLocation;
                useNotificationIcon = sf.UseNotificationIcon;
                hourlyForecast = sf.Hourly;
                descriptiveWind = sf.DescriptiveWind;
                symbolAsWindowIcon = sf.SymbolWindowIcon;
                symbolAsNotificationIcon = sf.SymbolNotificationIcon;

                Properties.Settings.Default.WeatherLocation = weatherLocation;
                Properties.Settings.Default.UseNotificationIcon = useNotificationIcon;
                Properties.Settings.Default.Hourly = hourlyForecast;
                Properties.Settings.Default.DescriptiveWind = descriptiveWind;
                Properties.Settings.Default.SymbolWindowIcon = symbolAsWindowIcon;
                Properties.Settings.Default.SymbolNotificationIcon = symbolAsNotificationIcon;
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

        private void creditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(data.Credit.Link.Url);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var grouped = forecastBox.SelectedItems
                .Cast<ListViewItem>().GroupBy(x => x.Group);
            var sb = new StringBuilder();
            foreach (var g in grouped)
            {
                sb.AppendLine("# " + g.Key.Header);
                foreach(var i in g)
                {
                    var t = (TabularTime)i.Tag;
                    sb.AppendLine(String.Format("{0}-{1}\t{2}\t{3}\t{4}\t{5}\t{6}",
                        t.From.ToShortTimeString(), t.To.ToShortTimeString(),
                        t.Symbol.Name, t.Temperature.ToString(),
                        t.Precipitation.ToString(), t.Wind(descriptiveWind),
                        t.Pressure.ToString()));
                }
            }
            if (sb.Length > 0)
                Clipboard.SetText(sb.ToString());
        }
    }
}
