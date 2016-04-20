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
            this.refreshButton = new System.Windows.Forms.Button();
            this.forecastBox = new System.Windows.Forms.ListView();
            this.periodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precipCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.windCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pressureCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conditionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sunLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lastUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextUpdateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linksButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longTermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsNotifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.overviewNotifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyNotifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longTermNotifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radarNotifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Location = new System.Drawing.Point(462, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "&Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // forecastBox
            // 
            this.forecastBox.AllowColumnReorder = true;
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
            this.forecastBox.Location = new System.Drawing.Point(12, 41);
            this.forecastBox.Name = "forecastBox";
            this.forecastBox.Size = new System.Drawing.Size(525, 284);
            this.forecastBox.TabIndex = 0;
            this.forecastBox.UseCompatibleStateImageBehavior = false;
            this.forecastBox.View = System.Windows.Forms.View.Details;
            // 
            // periodCol
            // 
            this.periodCol.Text = "Period";
            this.periodCol.Width = 140;
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
            // conditionCol
            // 
            this.conditionCol.Text = "Conditions";
            this.conditionCol.Width = 80;
            // 
            // sunLabel
            // 
            this.sunLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sunLabel.Location = new System.Drawing.Point(9, 12);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(447, 23);
            this.sunLabel.TabIndex = 3;
            this.sunLabel.Text = " ";
            this.sunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastUpdateLabel,
            this.nextUpdateLabel,
            this.linksButton});
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
            // linksButton
            // 
            this.linksButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.linksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.linksButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.overviewToolStripMenuItem,
            this.hourlyToolStripMenuItem,
            this.longTermToolStripMenuItem,
            this.radarToolStripMenuItem});
            this.linksButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linksButton.Name = "linksButton";
            this.linksButton.Size = new System.Drawing.Size(47, 20);
            this.linksButton.Text = "Links";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "&Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overviewToolStripMenuItem.Text = "&Overview";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // hourlyToolStripMenuItem
            // 
            this.hourlyToolStripMenuItem.Name = "hourlyToolStripMenuItem";
            this.hourlyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hourlyToolStripMenuItem.Text = "&Hourly";
            this.hourlyToolStripMenuItem.Click += new System.EventHandler(this.hourlyToolStripMenuItem_Click);
            // 
            // longTermToolStripMenuItem
            // 
            this.longTermToolStripMenuItem.Name = "longTermToolStripMenuItem";
            this.longTermToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.longTermToolStripMenuItem.Text = "&Long Term";
            this.longTermToolStripMenuItem.Click += new System.EventHandler(this.longTermToolStripMenuItem_Click);
            // 
            // radarToolStripMenuItem
            // 
            this.radarToolStripMenuItem.Name = "radarToolStripMenuItem";
            this.radarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.radarToolStripMenuItem.Text = "&Radar";
            this.radarToolStripMenuItem.Click += new System.EventHandler(this.radarToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem2,
            this.linksToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.notifyIconMenu.Size = new System.Drawing.Size(153, 76);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsNotifyMenuItem,
            this.toolStripSeparator1,
            this.overviewNotifyMenuItem,
            this.hourlyNotifyMenuItem,
            this.longTermNotifyMenuItem,
            this.radarNotifyMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linksToolStripMenuItem.Text = "&Links";
            // 
            // creditsNotifyMenuItem
            // 
            this.creditsNotifyMenuItem.Name = "creditsNotifyMenuItem";
            this.creditsNotifyMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsNotifyMenuItem.Text = "&Credits";
            this.creditsNotifyMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // overviewNotifyMenuItem
            // 
            this.overviewNotifyMenuItem.Name = "overviewNotifyMenuItem";
            this.overviewNotifyMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overviewNotifyMenuItem.Text = "&Overview";
            this.overviewNotifyMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // hourlyNotifyMenuItem
            // 
            this.hourlyNotifyMenuItem.Name = "hourlyNotifyMenuItem";
            this.hourlyNotifyMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hourlyNotifyMenuItem.Text = "&Hourly";
            this.hourlyNotifyMenuItem.Click += new System.EventHandler(this.hourlyToolStripMenuItem_Click);
            // 
            // longTermNotifyMenuItem
            // 
            this.longTermNotifyMenuItem.Name = "longTermNotifyMenuItem";
            this.longTermNotifyMenuItem.Size = new System.Drawing.Size(152, 22);
            this.longTermNotifyMenuItem.Text = "&Long Term";
            this.longTermNotifyMenuItem.Click += new System.EventHandler(this.longTermToolStripMenuItem_Click);
            // 
            // radarNotifyMenuItem
            // 
            this.radarNotifyMenuItem.Name = "radarNotifyMenuItem";
            this.radarNotifyMenuItem.Size = new System.Drawing.Size(152, 22);
            this.radarNotifyMenuItem.Text = "&Radar";
            this.radarNotifyMenuItem.Click += new System.EventHandler(this.radarToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 350);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.forecastBox);
            this.Controls.Add(this.sunLabel);
            this.Controls.Add(this.refreshButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
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
        private System.Windows.Forms.ToolStripDropDownButton linksButton;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem longTermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsNotifyMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem overviewNotifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyNotifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longTermNotifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radarNotifyMenuItem;
    }
}

