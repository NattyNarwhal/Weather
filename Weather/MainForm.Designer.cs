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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.forecastPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.forecastBox = new System.Windows.Forms.ListView();
            this.periodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precipCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.windCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pressureCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.forecastPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshButton.Location = new System.Drawing.Point(383, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "&Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.forecastPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 297);
            this.tabControl1.TabIndex = 1;
            // 
            // forecastPage
            // 
            this.forecastPage.Controls.Add(this.forecastBox);
            this.forecastPage.Location = new System.Drawing.Point(4, 22);
            this.forecastPage.Name = "forecastPage";
            this.forecastPage.Padding = new System.Windows.Forms.Padding(3);
            this.forecastPage.Size = new System.Drawing.Size(438, 271);
            this.forecastPage.TabIndex = 0;
            this.forecastPage.Text = "Forecast";
            this.forecastPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // forecastBox
            // 
            this.forecastBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.periodCol,
            this.tempCol,
            this.precipCol,
            this.windCol,
            this.pressureCol});
            this.forecastBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forecastBox.Location = new System.Drawing.Point(3, 3);
            this.forecastBox.Name = "forecastBox";
            this.forecastBox.Size = new System.Drawing.Size(432, 265);
            this.forecastBox.TabIndex = 0;
            this.forecastBox.UseCompatibleStateImageBehavior = false;
            this.forecastBox.View = System.Windows.Forms.View.Details;
            // 
            // periodCol
            // 
            this.periodCol.Text = "Period";
            this.periodCol.Width = 110;
            // 
            // tempCol
            // 
            this.tempCol.Text = "Temperature";
            this.tempCol.Width = 80;
            // 
            // precipCol
            // 
            this.precipCol.Text = "Precip.";
            this.precipCol.Width = 50;
            // 
            // windCol
            // 
            this.windCol.Text = "Wind";
            this.windCol.Width = 90;
            // 
            // pressureCol
            // 
            this.pressureCol.Text = "Pressure";
            this.pressureCol.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.refreshButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.forecastPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage forecastPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView forecastBox;
        private System.Windows.Forms.ColumnHeader periodCol;
        private System.Windows.Forms.ColumnHeader tempCol;
        private System.Windows.Forms.ColumnHeader precipCol;
        private System.Windows.Forms.ColumnHeader windCol;
        private System.Windows.Forms.ColumnHeader pressureCol;
    }
}

