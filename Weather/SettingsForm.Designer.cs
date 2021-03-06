﻿namespace Weather
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButtton = new System.Windows.Forms.Button();
            this.locationExplanation = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.descriptiveWindBox = new System.Windows.Forms.CheckBox();
            this.hourlyBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.locationPage = new System.Windows.Forms.TabPage();
            this.displayPage = new System.Windows.Forms.TabPage();
            this.imperialBox = new System.Windows.Forms.CheckBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.iconPage = new System.Windows.Forms.TabPage();
            this.windowIconGroup = new System.Windows.Forms.GroupBox();
            this.symbolAsWindowIconBox = new System.Windows.Forms.RadioButton();
            this.tempAsWindowIconBox = new System.Windows.Forms.RadioButton();
            this.notificationGroup = new System.Windows.Forms.GroupBox();
            this.symbolAsNotificationIconBox = new System.Windows.Forms.RadioButton();
            this.tempAsNotificationIconBox = new System.Windows.Forms.RadioButton();
            this.notificationEnableBox = new System.Windows.Forms.CheckBox();
            this.notificationExplanation = new System.Windows.Forms.Label();
            this.startHiddenBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.locationPage.SuspendLayout();
            this.displayPage.SuspendLayout();
            this.iconPage.SuspendLayout();
            this.windowIconGroup.SuspendLayout();
            this.notificationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(259, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButtton
            // 
            this.okButtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButtton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButtton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButtton.Location = new System.Drawing.Point(178, 252);
            this.okButtton.Name = "okButtton";
            this.okButtton.Size = new System.Drawing.Size(75, 23);
            this.okButtton.TabIndex = 10;
            this.okButtton.Text = "O&K";
            this.okButtton.UseVisualStyleBackColor = true;
            // 
            // locationExplanation
            // 
            this.locationExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationExplanation.Location = new System.Drawing.Point(6, 30);
            this.locationExplanation.Name = "locationExplanation";
            this.locationExplanation.Size = new System.Drawing.Size(302, 175);
            this.locationExplanation.TabIndex = 4;
            this.locationExplanation.Text = "You can get the path for your city by entering its URL section manually (such as " +
    "\"Canada/Ontario/Toronto\") or searching for it within the combo box. Suggestions " +
    "will be filled as you type.";
            // 
            // cityBox
            // 
            this.cityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cityBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(6, 6);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(302, 21);
            this.cityBox.TabIndex = 1;
            // 
            // descriptiveWindBox
            // 
            this.descriptiveWindBox.AutoSize = true;
            this.descriptiveWindBox.Location = new System.Drawing.Point(6, 57);
            this.descriptiveWindBox.Name = "descriptiveWindBox";
            this.descriptiveWindBox.Size = new System.Drawing.Size(101, 17);
            this.descriptiveWindBox.TabIndex = 4;
            this.descriptiveWindBox.Text = "Descripive wind";
            this.descriptiveWindBox.UseVisualStyleBackColor = true;
            // 
            // hourlyBox
            // 
            this.hourlyBox.AutoSize = true;
            this.hourlyBox.Location = new System.Drawing.Point(6, 33);
            this.hourlyBox.Name = "hourlyBox";
            this.hourlyBox.Size = new System.Drawing.Size(97, 17);
            this.hourlyBox.TabIndex = 3;
            this.hourlyBox.Text = "Hourly forecast";
            this.hourlyBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.locationPage);
            this.tabControl1.Controls.Add(this.displayPage);
            this.tabControl1.Controls.Add(this.iconPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 234);
            this.tabControl1.TabIndex = 9;
            // 
            // locationPage
            // 
            this.locationPage.Controls.Add(this.cityBox);
            this.locationPage.Controls.Add(this.locationExplanation);
            this.locationPage.Location = new System.Drawing.Point(4, 22);
            this.locationPage.Name = "locationPage";
            this.locationPage.Padding = new System.Windows.Forms.Padding(3);
            this.locationPage.Size = new System.Drawing.Size(314, 208);
            this.locationPage.TabIndex = 0;
            this.locationPage.Text = "Location";
            this.locationPage.UseVisualStyleBackColor = true;
            // 
            // displayPage
            // 
            this.displayPage.Controls.Add(this.startHiddenBox);
            this.displayPage.Controls.Add(this.imperialBox);
            this.displayPage.Controls.Add(this.languageLabel);
            this.displayPage.Controls.Add(this.languageBox);
            this.displayPage.Controls.Add(this.descriptiveWindBox);
            this.displayPage.Controls.Add(this.hourlyBox);
            this.displayPage.Location = new System.Drawing.Point(4, 22);
            this.displayPage.Name = "displayPage";
            this.displayPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayPage.Size = new System.Drawing.Size(314, 208);
            this.displayPage.TabIndex = 1;
            this.displayPage.Text = "Display";
            this.displayPage.UseVisualStyleBackColor = true;
            // 
            // imperialBox
            // 
            this.imperialBox.AutoSize = true;
            this.imperialBox.Location = new System.Drawing.Point(6, 81);
            this.imperialBox.Name = "imperialBox";
            this.imperialBox.Size = new System.Drawing.Size(87, 17);
            this.imperialBox.TabIndex = 10;
            this.imperialBox.Text = "Imperial units";
            this.imperialBox.UseVisualStyleBackColor = true;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(6, 9);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 9;
            this.languageLabel.Text = "Language:";
            // 
            // languageBox
            // 
            this.languageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(70, 6);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(238, 21);
            this.languageBox.TabIndex = 2;
            // 
            // iconPage
            // 
            this.iconPage.Controls.Add(this.windowIconGroup);
            this.iconPage.Controls.Add(this.notificationGroup);
            this.iconPage.Location = new System.Drawing.Point(4, 22);
            this.iconPage.Name = "iconPage";
            this.iconPage.Size = new System.Drawing.Size(314, 208);
            this.iconPage.TabIndex = 2;
            this.iconPage.Text = "Icons";
            this.iconPage.UseVisualStyleBackColor = true;
            // 
            // windowIconGroup
            // 
            this.windowIconGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowIconGroup.Controls.Add(this.symbolAsWindowIconBox);
            this.windowIconGroup.Controls.Add(this.tempAsWindowIconBox);
            this.windowIconGroup.Location = new System.Drawing.Point(6, 132);
            this.windowIconGroup.Name = "windowIconGroup";
            this.windowIconGroup.Size = new System.Drawing.Size(302, 73);
            this.windowIconGroup.TabIndex = 9;
            this.windowIconGroup.TabStop = false;
            this.windowIconGroup.Text = "Window";
            // 
            // symbolAsWindowIconBox
            // 
            this.symbolAsWindowIconBox.AutoSize = true;
            this.symbolAsWindowIconBox.Location = new System.Drawing.Point(6, 43);
            this.symbolAsWindowIconBox.Name = "symbolAsWindowIconBox";
            this.symbolAsWindowIconBox.Size = new System.Drawing.Size(225, 17);
            this.symbolAsWindowIconBox.TabIndex = 9;
            this.symbolAsWindowIconBox.Text = "Use symbol as icon, temperature as badge";
            this.symbolAsWindowIconBox.UseVisualStyleBackColor = true;
            // 
            // tempAsWindowIconBox
            // 
            this.tempAsWindowIconBox.AutoSize = true;
            this.tempAsWindowIconBox.Checked = true;
            this.tempAsWindowIconBox.Location = new System.Drawing.Point(6, 19);
            this.tempAsWindowIconBox.Name = "tempAsWindowIconBox";
            this.tempAsWindowIconBox.Size = new System.Drawing.Size(225, 17);
            this.tempAsWindowIconBox.TabIndex = 8;
            this.tempAsWindowIconBox.TabStop = true;
            this.tempAsWindowIconBox.Text = "Use temperature as icon, symbol as badge";
            this.tempAsWindowIconBox.UseVisualStyleBackColor = true;
            // 
            // notificationGroup
            // 
            this.notificationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationGroup.Controls.Add(this.symbolAsNotificationIconBox);
            this.notificationGroup.Controls.Add(this.tempAsNotificationIconBox);
            this.notificationGroup.Controls.Add(this.notificationEnableBox);
            this.notificationGroup.Controls.Add(this.notificationExplanation);
            this.notificationGroup.Location = new System.Drawing.Point(6, 6);
            this.notificationGroup.Name = "notificationGroup";
            this.notificationGroup.Size = new System.Drawing.Size(302, 120);
            this.notificationGroup.TabIndex = 9;
            this.notificationGroup.TabStop = false;
            this.notificationGroup.Text = "Notification Area";
            // 
            // symbolAsNotificationIconBox
            // 
            this.symbolAsNotificationIconBox.AutoSize = true;
            this.symbolAsNotificationIconBox.Location = new System.Drawing.Point(6, 96);
            this.symbolAsNotificationIconBox.Name = "symbolAsNotificationIconBox";
            this.symbolAsNotificationIconBox.Size = new System.Drawing.Size(116, 17);
            this.symbolAsNotificationIconBox.TabIndex = 7;
            this.symbolAsNotificationIconBox.Text = "Use symbol as icon";
            this.symbolAsNotificationIconBox.UseVisualStyleBackColor = true;
            // 
            // tempAsNotificationIconBox
            // 
            this.tempAsNotificationIconBox.AutoSize = true;
            this.tempAsNotificationIconBox.Checked = true;
            this.tempAsNotificationIconBox.Location = new System.Drawing.Point(6, 72);
            this.tempAsNotificationIconBox.Name = "tempAsNotificationIconBox";
            this.tempAsNotificationIconBox.Size = new System.Drawing.Size(140, 17);
            this.tempAsNotificationIconBox.TabIndex = 6;
            this.tempAsNotificationIconBox.TabStop = true;
            this.tempAsNotificationIconBox.Text = "Use temperature as icon";
            this.tempAsNotificationIconBox.UseVisualStyleBackColor = true;
            // 
            // notificationEnableBox
            // 
            this.notificationEnableBox.AutoSize = true;
            this.notificationEnableBox.Location = new System.Drawing.Point(6, 19);
            this.notificationEnableBox.Name = "notificationEnableBox";
            this.notificationEnableBox.Size = new System.Drawing.Size(164, 17);
            this.notificationEnableBox.TabIndex = 5;
            this.notificationEnableBox.Text = "Use the notification area icon";
            this.notificationEnableBox.UseVisualStyleBackColor = true;
            this.notificationEnableBox.CheckedChanged += new System.EventHandler(this.notificationEnableBox_CheckedChanged);
            // 
            // notificationExplanation
            // 
            this.notificationExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationExplanation.Location = new System.Drawing.Point(3, 40);
            this.notificationExplanation.Name = "notificationExplanation";
            this.notificationExplanation.Size = new System.Drawing.Size(299, 29);
            this.notificationExplanation.TabIndex = 8;
            this.notificationExplanation.Text = "If this is disabled and you\'re using Windows 7 or newer, then the taskbar icon wi" +
    "ll have a badge instead.";
            // 
            // startHiddenBox
            // 
            this.startHiddenBox.AutoSize = true;
            this.startHiddenBox.Location = new System.Drawing.Point(6, 104);
            this.startHiddenBox.Name = "startHiddenBox";
            this.startHiddenBox.Size = new System.Drawing.Size(83, 17);
            this.startHiddenBox.TabIndex = 11;
            this.startHiddenBox.Text = "Start hidden";
            this.startHiddenBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButtton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(346, 287);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okButtton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.locationPage.ResumeLayout(false);
            this.displayPage.ResumeLayout(false);
            this.displayPage.PerformLayout();
            this.iconPage.ResumeLayout(false);
            this.windowIconGroup.ResumeLayout(false);
            this.windowIconGroup.PerformLayout();
            this.notificationGroup.ResumeLayout(false);
            this.notificationGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButtton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label locationExplanation;
        private System.Windows.Forms.CheckBox hourlyBox;
        private System.Windows.Forms.CheckBox descriptiveWindBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage locationPage;
        private System.Windows.Forms.TabPage displayPage;
        private System.Windows.Forms.TabPage iconPage;
        private System.Windows.Forms.CheckBox notificationEnableBox;
        private System.Windows.Forms.Label notificationExplanation;
        private System.Windows.Forms.GroupBox windowIconGroup;
        private System.Windows.Forms.RadioButton symbolAsWindowIconBox;
        private System.Windows.Forms.RadioButton tempAsWindowIconBox;
        private System.Windows.Forms.GroupBox notificationGroup;
        private System.Windows.Forms.RadioButton symbolAsNotificationIconBox;
        private System.Windows.Forms.RadioButton tempAsNotificationIconBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.CheckBox imperialBox;
        private System.Windows.Forms.CheckBox startHiddenBox;
    }
}