namespace LiMS.View.Import
{
    partial class ImportForm
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
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.filePathTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.importingPanel = new DevComponents.DotNetBar.PanelEx();
            this.importProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.importButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.memberRadioButton = new System.Windows.Forms.RadioButton();
            this.bookRadioButton = new System.Windows.Forms.RadioButton();
            this.browseButton = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.importingPanel.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(542, 77);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(186, 45);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "LiMS - Import";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.filePathTextBox);
            this.panelEx1.Controls.Add(this.importingPanel);
            this.panelEx1.Controls.Add(this.importButton);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 77);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(542, 187);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 115);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(45, 22);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Path :";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.filePathTextBox.Border.Class = "TextBoxBorder";
            this.filePathTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.filePathTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.filePathTextBox.ForeColor = System.Drawing.Color.Black;
            this.filePathTextBox.Location = new System.Drawing.Point(63, 115);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.PreventEnterBeep = true;
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(466, 22);
            this.filePathTextBox.TabIndex = 12;
            // 
            // importingPanel
            // 
            this.importingPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.importingPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.importingPanel.Controls.Add(this.importProgress);
            this.importingPanel.Controls.Add(this.labelX3);
            this.importingPanel.Controls.Add(this.labelX1);
            this.importingPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.importingPanel.Location = new System.Drawing.Point(81, 169);
            this.importingPanel.Name = "importingPanel";
            this.importingPanel.Size = new System.Drawing.Size(539, 181);
            this.importingPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.importingPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.importingPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.importingPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.importingPanel.Style.GradientAngle = 90;
            this.importingPanel.TabIndex = 11;
            // 
            // importProgress
            // 
            this.importProgress.AnimationSpeed = 50;
            // 
            // 
            // 
            this.importProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.importProgress.Location = new System.Drawing.Point(273, 77);
            this.importProgress.Name = "importProgress";
            this.importProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.importProgress.Size = new System.Drawing.Size(30, 23);
            this.importProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.importProgress.TabIndex = 9;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(209, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Importing...";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(464, 83);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "labelX1";
            // 
            // importButton
            // 
            this.importButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.importButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.importButton.Location = new System.Drawing.Point(234, 143);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Import";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.buttonX3);
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(309, 6);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(230, 65);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 9;
            this.groupPanel2.Text = "Template";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(123, 3);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(94, 32);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 1;
            this.buttonX3.Text = "Members";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(23, 3);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(94, 32);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Books";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.memberRadioButton);
            this.groupPanel1.Controls.Add(this.bookRadioButton);
            this.groupPanel1.Controls.Add(this.browseButton);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 6);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(171, 103);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 7;
            this.groupPanel1.Text = "Import";
            // 
            // memberRadioButton
            // 
            this.memberRadioButton.Location = new System.Drawing.Point(16, 26);
            this.memberRadioButton.Name = "memberRadioButton";
            this.memberRadioButton.Size = new System.Drawing.Size(85, 17);
            this.memberRadioButton.TabIndex = 1;
            this.memberRadioButton.Text = "Members";
            this.memberRadioButton.UseVisualStyleBackColor = true;
            // 
            // bookRadioButton
            // 
            this.bookRadioButton.Checked = true;
            this.bookRadioButton.Location = new System.Drawing.Point(16, 3);
            this.bookRadioButton.Name = "bookRadioButton";
            this.bookRadioButton.Size = new System.Drawing.Size(85, 17);
            this.bookRadioButton.TabIndex = 0;
            this.bookRadioButton.TabStop = true;
            this.bookRadioButton.Text = "Books";
            this.bookRadioButton.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.browseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.browseButton.Location = new System.Drawing.Point(87, 54);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "csv";
            this.openFileDialog.Filter = "CSV (Comma Delimited) | *.csv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "CSV (Comma Delimited) | *.csv";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 264);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import - LiMS";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.importingPanel.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.RadioButton memberRadioButton;
        private System.Windows.Forms.RadioButton bookRadioButton;
        private DevComponents.DotNetBar.ButtonX browseButton;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.PanelEx importingPanel;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CircularProgress importProgress;
        private DevComponents.DotNetBar.ButtonX importButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevComponents.DotNetBar.Controls.TextBoxX filePathTextBox;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}