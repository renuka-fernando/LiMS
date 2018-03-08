namespace LiMS.Database
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.userIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.passwordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.serverTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.ExitButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.userIdTextBox.Border.Class = "TextBoxBorder";
            this.userIdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userIdTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.userIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.ForeColor = System.Drawing.Color.Black;
            this.userIdTextBox.Location = new System.Drawing.Point(164, 71);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.PreventEnterBeep = true;
            this.userIdTextBox.Size = new System.Drawing.Size(238, 29);
            this.userIdTextBox.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(34, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 28);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "User ID";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(164, 106);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PreventEnterBeep = true;
            this.passwordTextBox.Size = new System.Drawing.Size(238, 29);
            this.passwordTextBox.TabIndex = 5;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(34, 104);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 28);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Password";
            // 
            // serverTextBox
            // 
            this.serverTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.serverTextBox.Border.Class = "TextBoxBorder";
            this.serverTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.serverTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTextBox.ForeColor = System.Drawing.Color.Black;
            this.serverTextBox.Location = new System.Drawing.Point(164, 141);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.PreventEnterBeep = true;
            this.serverTextBox.Size = new System.Drawing.Size(238, 29);
            this.serverTextBox.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(34, 139);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(95, 28);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Server";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(227, 176);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ExitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(330, 176);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 23);
            this.ExitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX userIdTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX passwordTextBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX serverTextBox;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX ExitButton;
    }
}