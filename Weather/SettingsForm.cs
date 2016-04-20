﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weather
{
    public partial class SettingsForm : Form
    {
        string old = "";

        public string WeatherLocation
        {
            get { return cityBox.Text; }
            set { cityBox.Text = value; }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void cityBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cityBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cityBox, "");
        }
    }
}
