namespace LiMS.MyControl.HolidayCalender
{
    partial class HolidayCalender
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cellsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.monthLabel = new DevComponents.DotNetBar.LabelX();
            this.dayNameFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.clearButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // cellsFlowLayout
            // 
            this.cellsFlowLayout.Location = new System.Drawing.Point(4, 69);
            this.cellsFlowLayout.Name = "cellsFlowLayout";
            this.cellsFlowLayout.Size = new System.Drawing.Size(400, 279);
            this.cellsFlowLayout.TabIndex = 0;
            // 
            // monthLabel
            // 
            // 
            // 
            // 
            this.monthLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(0, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(411, 36);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "January 2016";
            this.monthLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dayNameFlowLayout
            // 
            this.dayNameFlowLayout.Location = new System.Drawing.Point(5, 42);
            this.dayNameFlowLayout.Name = "dayNameFlowLayout";
            this.dayNameFlowLayout.Size = new System.Drawing.Size(400, 27);
            this.dayNameFlowLayout.TabIndex = 2;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(16, 64);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(376, 5);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // clearButton
            // 
            this.clearButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(369, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.clearButton.Size = new System.Drawing.Size(35, 33);
            this.clearButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.clearButton.Symbol = "";
            this.clearButton.TabIndex = 3;
            this.clearButton.Tooltip = "Clear All";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // HolidayCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.dayNameFlowLayout);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.cellsFlowLayout);
            this.Name = "HolidayCalender";
            this.Size = new System.Drawing.Size(411, 357);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cellsFlowLayout;
        private DevComponents.DotNetBar.LabelX monthLabel;
        private System.Windows.Forms.FlowLayoutPanel dayNameFlowLayout;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.ButtonX clearButton;
    }
}
