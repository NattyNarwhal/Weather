namespace Weather
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
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButtton = new System.Windows.Forms.Button();
            this.locationExplanation = new System.Windows.Forms.Label();
            this.notificationEnableBox = new System.Windows.Forms.CheckBox();
            this.notificationExplanation = new System.Windows.Forms.Label();
            this.locationGroup = new System.Windows.Forms.GroupBox();
            this.displayGroup = new System.Windows.Forms.GroupBox();
            this.locationGroup.SuspendLayout();
            this.displayGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityBox.Location = new System.Drawing.Point(6, 19);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(251, 20);
            this.cityBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(197, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButtton
            // 
            this.okButtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButtton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButtton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButtton.Location = new System.Drawing.Point(116, 214);
            this.okButtton.Name = "okButtton";
            this.okButtton.Size = new System.Drawing.Size(75, 23);
            this.okButtton.TabIndex = 3;
            this.okButtton.Text = "O&K";
            this.okButtton.UseVisualStyleBackColor = true;
            // 
            // locationExplanation
            // 
            this.locationExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationExplanation.Location = new System.Drawing.Point(6, 42);
            this.locationExplanation.Name = "locationExplanation";
            this.locationExplanation.Size = new System.Drawing.Size(248, 49);
            this.locationExplanation.TabIndex = 4;
            this.locationExplanation.Text = "You can get the path for your city (like \"Canada/Ontario/Toronto\") by looking it " +
    "up on yr.no.";
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
            // 
            // notificationExplanation
            // 
            this.notificationExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationExplanation.Location = new System.Drawing.Point(6, 39);
            this.notificationExplanation.Name = "notificationExplanation";
            this.notificationExplanation.Size = new System.Drawing.Size(248, 48);
            this.notificationExplanation.TabIndex = 6;
            this.notificationExplanation.Text = "If this is disabled and you\'re using Windows 7 or newer, then the taskbar icon wi" +
    "ll have the icon as a badge instead.";
            // 
            // locationGroup
            // 
            this.locationGroup.Controls.Add(this.cityBox);
            this.locationGroup.Controls.Add(this.locationExplanation);
            this.locationGroup.Location = new System.Drawing.Point(12, 12);
            this.locationGroup.Name = "locationGroup";
            this.locationGroup.Size = new System.Drawing.Size(260, 94);
            this.locationGroup.TabIndex = 7;
            this.locationGroup.TabStop = false;
            this.locationGroup.Text = "Location";
            // 
            // displayGroup
            // 
            this.displayGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayGroup.Controls.Add(this.notificationEnableBox);
            this.displayGroup.Controls.Add(this.notificationExplanation);
            this.displayGroup.Location = new System.Drawing.Point(12, 112);
            this.displayGroup.Name = "displayGroup";
            this.displayGroup.Size = new System.Drawing.Size(260, 90);
            this.displayGroup.TabIndex = 8;
            this.displayGroup.TabStop = false;
            this.displayGroup.Text = "Display";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButtton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.displayGroup);
            this.Controls.Add(this.locationGroup);
            this.Controls.Add(this.okButtton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.locationGroup.ResumeLayout(false);
            this.locationGroup.PerformLayout();
            this.displayGroup.ResumeLayout(false);
            this.displayGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Button okButtton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label locationExplanation;
        private System.Windows.Forms.CheckBox notificationEnableBox;
        private System.Windows.Forms.Label notificationExplanation;
        private System.Windows.Forms.GroupBox locationGroup;
        private System.Windows.Forms.GroupBox displayGroup;
    }
}