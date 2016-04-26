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
                return ((AvailableLocation)cityBox.SelectedItem)?.UrlSubsection()
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

        public bool SymbolNotificationIcon
        {
            get { return symbolAsNotificationIconBox.Checked; }
            set { symbolAsNotificationIconBox.Checked = value; }
        }

        public bool SymbolWindowIcon
        {
            get { return symbolAsWindowIconBox.Checked; }
            set { symbolAsWindowIconBox.Checked = value; }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var list = AvailableLocation.GetList().ToArray();

            cityBox.Items.AddRange(list);
            cityBox.SelectedItem = list.Where(x => x.XmlUrl.Contains(WeatherLocation)).FirstOrDefault();
        }
    }
}
