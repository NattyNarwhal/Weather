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
                return ((AvailableLocation)cityBox.SelectedItem)?.XmlUrl
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

            cityBox.Items.AddRange(AvailableLocation.GetList().ToArray());
        }
    }
}
