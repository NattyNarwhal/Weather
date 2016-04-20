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
            this.refreshButton = new System.Windows.Forms.Button();
            this.forecastBox = new System.Windows.Forms.ListView();
            this.periodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precipCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.windCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pressureCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conditionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditsLink = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
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
            // 
            // forecastBox
            // 
            this.forecastBox.AllowColumnReorder = true;
            this.forecastBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.periodCol,
            this.conditionCol,
            this.tempCol,
            this.precipCol,
            this.windCol,
            this.pressureCol});
            this.forecastBox.Location = new System.Drawing.Point(12, 41);
            this.forecastBox.Name = "forecastBox";
            this.forecastBox.Size = new System.Drawing.Size(525, 278);
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
            // creditsLink
            // 
            this.creditsLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsLink.Location = new System.Drawing.Point(9, 322);
            this.creditsLink.Name = "creditsLink";
            this.creditsLink.Size = new System.Drawing.Size(528, 19);
            this.creditsLink.TabIndex = 2;
            this.creditsLink.TabStop = true;
            this.creditsLink.Text = "&Credits";
            this.creditsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creditsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLink_LinkClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Location = new System.Drawing.Point(9, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(447, 23);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 350);
            this.Controls.Add(this.forecastBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.creditsLink);
            this.Controls.Add(this.refreshButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.LinkLabel creditsLink;
        private System.Windows.Forms.Label statusLabel;
    }
}

