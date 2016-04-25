using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather
{
    public partial class SettingsForm : Form
    {
        public string WeatherLocation
        {
            get
            {
                return ((SearchResult)cityBox.SelectedItem)?.Url
                    ?? cityBox.Text;
            }
            set { cityBox.Text = value; }
        }

        public bool UseNotificationIcon
        {
            get { return notificationEnableBox.Checked; }
            set { notificationEnableBox.Checked = value; }
        }

        public bool Hourly
        {
            get { return hourlyBox.Checked; }
            set { hourlyBox.Checked = value; }
        }

        public bool DescriptiveWind
        {
            get { return descriptiveWindBox.Checked; }
            set { descriptiveWindBox.Checked = value; }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            // We only start with 5 items as to produce more useful
            // results and avoid hammering the server.
            if (cityBox.Text.Length > 4)
            {
                // If we remove the first item, that's what the user is
                // currently typing, and bad things will then happen.
                while (cityBox.Items.Count > 1)
                {
                    cityBox.Items.RemoveAt(cityBox.Items.Count - 1);
                }
                cityBox.Items.AddRange(Fetcher.GetCompletions(cityBox.Text).ToArray());
            }
        }
    }
}
