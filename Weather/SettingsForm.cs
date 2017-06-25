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
                if (cityBox.SelectedItem != null)
                    return ((AvailableLocation)cityBox.SelectedItem)
                        ?.UrlSubsection(Language);
                else
                    return cityBox.Text;
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

        public bool ImperialUnits
        {
            get { return imperialBox.Checked; }
            set { imperialBox.Checked = value; }
        }

        public bool StartHidden
        {
            get { return startHiddenBox.Checked; }
            set { startHiddenBox.Checked = value; }
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

        public ServiceLanguage Language
        {
            get
            {
                return ((ServiceLanguageWrapper)languageBox.SelectedItem).Language;
            }
            set
            {
                languageBox.SelectedItem =
                    languageBox.Items.Cast<ServiceLanguageWrapper>()
                    .Where(x => x.Language == value).First();
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
            languageBox.Items.AddRange(ServiceLanguageWrapper.GetAllPossible());
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var list = AvailableLocation.GetList().ToArray();

            cityBox.Items.AddRange(list);

            if (Language == ServiceLanguage.NorwegianBokmal)
                cityBox.SelectedItem =
                    list.Where(x => x.XmlUrlBokmal.Contains(WeatherLocation)).FirstOrDefault();
            else if (Language == ServiceLanguage.NorwegianNynorsk)
                cityBox.SelectedItem =
                    list.Where(x => x.XmlUrlNynorsk.Contains(WeatherLocation)).FirstOrDefault();
            else
                cityBox.SelectedItem =
                    list.Where(x => x.XmlUrl.Contains(WeatherLocation)).FirstOrDefault();
        }

        private void notificationEnableBox_CheckedChanged(object sender, EventArgs e)
        {
            symbolAsNotificationIconBox.Enabled = notificationEnableBox.Checked;
            tempAsNotificationIconBox.Enabled = notificationEnableBox.Checked;
        }
    }
}
