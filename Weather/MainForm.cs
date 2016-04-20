using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            catch (Exception)
            {

            }
        }

        public void SyncState()
        {
            Text = data.Location.ToString();
            creditsLink.Text = data.Credit.Link.Text;
            statusLabel.Text = String.Format("Last update: {0} Next update: {1}",
                data.Meta.LastUpdate, data.Meta.NextUpdate);

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
                    lvi.Text = string.Format("{0} - {1}",
                        i.From.ToShortTimeString(), i.To.ToShortTimeString());
                    lvi.SubItems.Add(i.Symbol.Name);
                    lvi.SubItems.Add(i.Temperature.ToString());
                    lvi.SubItems.Add(i.Precipitation.ToString());
                    lvi.SubItems.Add(string.Format("{0} m/s {1}",
                        i.WindSpeed.MetersPerSecond.ToString(), i.WindDirection.Code));
                    lvi.SubItems.Add(i.Pressure.ToString());
                    forecastBox.Items.Add(lvi);
                }
            }
        }

        private void creditsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(data.Credit.Link.Url);
        }
    }
}
