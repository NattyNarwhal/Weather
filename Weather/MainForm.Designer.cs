namespace Weather
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.forecastBox = new System.Windows.Forms.ListView();
            this.periodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conditionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precipCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.windCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pressureCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lastUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longTermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.updatePollTimer = new System.Windows.Forms.Timer(this.components);
            this.creditLink = new System.Windows.Forms.LinkLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.linksMenu.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forecastBox
            // 
            this.forecastBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forecastBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.periodCol,
            this.conditionCol,
            this.tempCol,
            this.precipCol,
            this.windCol,
            this.pressureCol});
            this.forecastBox.ContextMenuStrip = this.listMenu;
            this.forecastBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.forecastBox.Location = new System.Drawing.Point(12, 50);
            this.forecastBox.Name = "forecastBox";
            this.forecastBox.ShowItemToolTips = true;
            this.forecastBox.Size = new System.Drawing.Size(525, 252);
            this.forecastBox.TabIndex = 0;
            this.forecastBox.UseCompatibleStateImageBehavior = false;
            this.forecastBox.View = System.Windows.Forms.View.Details;
            // 
            // periodCol
            // 
            this.periodCol.Text = "Period";
            this.periodCol.Width = 140;
            // 
            // conditionCol
            // 
            this.conditionCol.Text = "Conditions";
            this.conditionCol.Width = 80;
            // 
            // tempCol
            // 
            this.tempCol.Text = "Temp.";
            this.tempCol.Width = 50;
            // 
            // precipCol
            // 
            this.precipCol.Text = "Precip.";
            this.precipCol.Width = 50;
            // 
            // windCol
            // 
            this.windCol.Text = "Wind";
            this.windCol.Width = 100;
            // 
            // pressureCol
            // 
            this.pressureCol.Text = "Pressure";
            this.pressureCol.Width = 70;
            // 
            // listMenu
            // 
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.listMenu.Name = "listMenu";
            this.listMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.listMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // sunLabel
            // 
            this.sunLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sunLabel.Location = new System.Drawing.Point(12, 24);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(525, 23);
            this.sunLabel.TabIndex = 3;
            this.sunLabel.Text = " ";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastUpdateLabel,
            this.nextUpdateLabel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(69, 17);
            this.lastUpdateLabel.Text = "Last Update";
            // 
            // nextUpdateLabel
            // 
            this.nextUpdateLabel.Name = "nextUpdateLabel";
            this.nextUpdateLabel.Size = new System.Drawing.Size(72, 17);
            this.nextUpdateLabel.Text = "Next Update";
            // 
            // linksMenu
            // 
            this.linksMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.hourlyToolStripMenuItem,
            this.longTermToolStripMenuItem,
            this.radarToolStripMenuItem});
            this.linksMenu.Name = "linksMenu";
            this.linksMenu.Size = new System.Drawing.Size(132, 92);
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.overviewToolStripMenuItem.Text = "&Overview";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // hourlyToolStripMenuItem
            // 
            this.hourlyToolStripMenuItem.Name = "hourlyToolStripMenuItem";
            this.hourlyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.hourlyToolStripMenuItem.Text = "&Hourly";
            this.hourlyToolStripMenuItem.Click += new System.EventHandler(this.hourlyToolStripMenuItem_Click);
            // 
            // longTermToolStripMenuItem
            // 
            this.longTermToolStripMenuItem.Name = "longTermToolStripMenuItem";
            this.longTermToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.longTermToolStripMenuItem.Text = "&Long Term";
            this.longTermToolStripMenuItem.Click += new System.EventHandler(this.longTermToolStripMenuItem_Click);
            // 
            // radarToolStripMenuItem
            // 
            this.radarToolStripMenuItem.Name = "radarToolStripMenuItem";
            this.radarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.radarToolStripMenuItem.Text = "&Radar";
            this.radarToolStripMenuItem.Click += new System.EventHandler(this.radarToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.OwnerItem = this.weatherToolStripMenuItem;
            this.notifyIconMenu.Size = new System.Drawing.Size(155, 98);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 6);
            // 
            // updatePollTimer
            // 
            this.updatePollTimer.Enabled = true;
            this.updatePollTimer.Interval = 3600000;
            this.updatePollTimer.Tick += new System.EventHandler(this.updatePollTimer_Tick);
            // 
            // creditLink
            // 
            this.creditLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditLink.Location = new System.Drawing.Point(12, 305);
            this.creditLink.Name = "creditLink";
            this.creditLink.Size = new System.Drawing.Size(525, 23);
            this.creditLink.TabIndex = 6;
            this.creditLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditLink_LinkClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weatherToolStripMenuItem,
            this.linksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.DropDown = this.notifyIconMenu;
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.weatherToolStripMenuItem.Text = "&Weather";
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDown = this.linksMenu;
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.linksToolStripMenuItem.Text = "&Links";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 350);
            this.Controls.Add(this.creditLink);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.forecastBox);
            this.Controls.Add(this.sunLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Weather";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.listMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.linksMenu.ResumeLayout(false);
            this.notifyIconMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView forecastBox;
        private System.Windows.Forms.ColumnHeader periodCol;
        private System.Windows.Forms.ColumnHeader tempCol;
        private System.Windows.Forms.ColumnHeader precipCol;
        private System.Windows.Forms.ColumnHeader windCol;
        private System.Windows.Forms.ColumnHeader pressureCol;
        private System.Windows.Forms.ColumnHeader conditionCol;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lastUpdateLabel;
        private System.Windows.Forms.ToolStripStatusLabel nextUpdateLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip linksMenu;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longTermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer updatePollTimer;
        private System.Windows.Forms.LinkLabel creditLink;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
    }
}

