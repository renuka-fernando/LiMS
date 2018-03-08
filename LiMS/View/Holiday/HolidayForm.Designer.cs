namespace LiMS.View.Holiday
{
    partial class HolidayForm
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolidayForm));
            this.holidayColourLabel = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.holidayCalender = new LiMS.MyControl.HolidayCalender.HolidayCalender();
            this.SuspendLayout();
            // 
            // holidayColourLabel
            // 
            this.holidayColourLabel.BackColor = System.Drawing.Color.LightCoral;
            this.holidayColourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayColourLabel.ForeColor = System.Drawing.Color.Black;
            this.holidayColourLabel.Location = new System.Drawing.Point(564, 51);
            this.holidayColourLabel.Name = "holidayColourLabel";
            this.holidayColourLabel.Size = new System.Drawing.Size(25, 23);
            this.holidayColourLabel.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(483, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Holidays";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(572, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Specify holidays.................";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(564, 312);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(483, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            // 
            // holidayCalender
            // 
            this.holidayCalender.BackColor = System.Drawing.SystemColors.Window;
            this.holidayCalender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayCalender.Location = new System.Drawing.Point(12, 51);
            this.holidayCalender.Name = "holidayCalender";
            this.holidayCalender.SelectedDays = ((System.Collections.Generic.List<int>)(resources.GetObject("holidayCalender.SelectedDays")));
            this.holidayCalender.Size = new System.Drawing.Size(465, 284);
            this.holidayCalender.TabIndex = 6;
            // 
            // HolidayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 339);
            this.Controls.Add(this.holidayCalender);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.holidayColourLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiMS - Holiday";
            this.Load += new System.EventHandler(this.HolidayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HolidayForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Label holidayColourLabel;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private MyControl.HolidayCalender.HolidayCalender holidayCalender;
    }
}