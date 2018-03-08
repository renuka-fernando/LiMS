namespace LiMS.View.Home
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.MembersButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.transactionButton = new DevComponents.DotNetBar.ButtonX();
            this.BooksButton = new DevComponents.DotNetBar.ButtonX();
            this.holidayButton = new DevComponents.DotNetBar.ButtonX();
            this.memberReportButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bookReportButton = new DevComponents.DotNetBar.ButtonX();
            this.bookTypeButton = new DevComponents.DotNetBar.ButtonX();
            this.bookHistoryButton = new DevComponents.DotNetBar.ButtonX();
            this.memberHistoryButton = new DevComponents.DotNetBar.ButtonX();
            this.button1 = new System.Windows.Forms.Button();
            this.holidayCalender = new LiMS.MyControl.HolidayCalender.HolidayCalender();
            this.sequenceButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(150)))), ((int)(((byte)(178))))));
            // 
            // MembersButton
            // 
            this.MembersButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.MembersButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.MembersButton.Location = new System.Drawing.Point(211, 249);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(166, 80);
            this.MembersButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MembersButton.Symbol = "";
            this.MembersButton.TabIndex = 3;
            this.MembersButton.Text = "Add &Members";
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(13, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(141, 53);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "LiMS";
            // 
            // transactionButton
            // 
            this.transactionButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.transactionButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.transactionButton.Location = new System.Drawing.Point(39, 163);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(166, 166);
            this.transactionButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.transactionButton.Symbol = "";
            this.transactionButton.TabIndex = 0;
            this.transactionButton.Text = "&Transactions";
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // BooksButton
            // 
            this.BooksButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BooksButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BooksButton.Location = new System.Drawing.Point(39, 335);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(166, 80);
            this.BooksButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BooksButton.Symbol = "";
            this.BooksButton.TabIndex = 4;
            this.BooksButton.Text = "Add &Books";
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // holidayButton
            // 
            this.holidayButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.holidayButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.holidayButton.Location = new System.Drawing.Point(429, 163);
            this.holidayButton.Name = "holidayButton";
            this.holidayButton.Size = new System.Drawing.Size(80, 80);
            this.holidayButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.holidayButton.Symbol = "";
            this.holidayButton.TabIndex = 5;
            this.holidayButton.Text = "&Holidays";
            this.holidayButton.Click += new System.EventHandler(this.holidayButton_Click);
            // 
            // memberReportButton
            // 
            this.memberReportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.memberReportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.memberReportButton.Location = new System.Drawing.Point(297, 163);
            this.memberReportButton.Name = "memberReportButton";
            this.memberReportButton.Size = new System.Drawing.Size(80, 80);
            this.memberReportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.memberReportButton.Symbol = "";
            this.memberReportButton.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(150)))), ((int)(((byte)(178)))));
            this.memberReportButton.TabIndex = 2;
            this.memberReportButton.Text = "Report &Members";
            this.memberReportButton.Click += new System.EventHandler(this.memberReportButton_Click);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(16, 79);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(434, 36);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Gnanapradeepa Library - Bandaragama";
            // 
            // bookReportButton
            // 
            this.bookReportButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bookReportButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bookReportButton.Location = new System.Drawing.Point(211, 335);
            this.bookReportButton.Name = "bookReportButton";
            this.bookReportButton.Size = new System.Drawing.Size(80, 80);
            this.bookReportButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bookReportButton.Symbol = "";
            this.bookReportButton.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(150)))), ((int)(((byte)(178)))));
            this.bookReportButton.TabIndex = 9;
            this.bookReportButton.Text = "Report &Books";
            this.bookReportButton.Click += new System.EventHandler(this.bookReportButton_Click);
            // 
            // bookTypeButton
            // 
            this.bookTypeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bookTypeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bookTypeButton.Location = new System.Drawing.Point(39, 421);
            this.bookTypeButton.Name = "bookTypeButton";
            this.bookTypeButton.Size = new System.Drawing.Size(80, 37);
            this.bookTypeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bookTypeButton.Symbol = "";
            this.bookTypeButton.TabIndex = 10;
            this.bookTypeButton.Text = "Book &Types";
            this.bookTypeButton.Click += new System.EventHandler(this.bookTypeButton_Click);
            // 
            // bookHistoryButton
            // 
            this.bookHistoryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bookHistoryButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bookHistoryButton.Location = new System.Drawing.Point(297, 335);
            this.bookHistoryButton.Name = "bookHistoryButton";
            this.bookHistoryButton.Size = new System.Drawing.Size(80, 80);
            this.bookHistoryButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bookHistoryButton.Symbol = "";
            this.bookHistoryButton.TabIndex = 11;
            this.bookHistoryButton.Text = "B&ook History";
            this.bookHistoryButton.Click += new System.EventHandler(this.bookHistoryButton_Click);
            // 
            // memberHistoryButton
            // 
            this.memberHistoryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.memberHistoryButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.memberHistoryButton.Location = new System.Drawing.Point(211, 163);
            this.memberHistoryButton.Name = "memberHistoryButton";
            this.memberHistoryButton.Size = new System.Drawing.Size(80, 80);
            this.memberHistoryButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.memberHistoryButton.Symbol = "";
            this.memberHistoryButton.TabIndex = 12;
            this.memberHistoryButton.Text = "Mem&ber History";
            this.memberHistoryButton.Click += new System.EventHandler(this.memberHistoryButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(864, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Renuka";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // holidayCalender
            // 
            this.holidayCalender.BackColor = System.Drawing.Color.White;
            this.holidayCalender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayCalender.Enabled = false;
            this.holidayCalender.ForeColor = System.Drawing.Color.Black;
            this.holidayCalender.Location = new System.Drawing.Point(515, 163);
            this.holidayCalender.Name = "holidayCalender";
            this.holidayCalender.SelectedDays = ((System.Collections.Generic.List<int>)(resources.GetObject("holidayCalender.SelectedDays")));
            this.holidayCalender.Size = new System.Drawing.Size(465, 284);
            this.holidayCalender.TabIndex = 13;
            // 
            // sequenceButton
            // 
            this.sequenceButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sequenceButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.sequenceButton.Location = new System.Drawing.Point(429, 335);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(80, 80);
            this.sequenceButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sequenceButton.Symbol = "";
            this.sequenceButton.TabIndex = 14;
            this.sequenceButton.Text = "Type &Sequence";
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 470);
            this.Controls.Add(this.sequenceButton);
            this.Controls.Add(this.holidayCalender);
            this.Controls.Add(this.memberHistoryButton);
            this.Controls.Add(this.bookHistoryButton);
            this.Controls.Add(this.bookTypeButton);
            this.Controls.Add(this.bookReportButton);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.memberReportButton);
            this.Controls.Add(this.holidayButton);
            this.Controls.Add(this.BooksButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MembersButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiMS";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX MembersButton;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.ButtonX transactionButton;
        private DevComponents.DotNetBar.ButtonX BooksButton;
        private DevComponents.DotNetBar.ButtonX holidayButton;
        private DevComponents.DotNetBar.ButtonX memberReportButton;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bookReportButton;
        private DevComponents.DotNetBar.ButtonX bookTypeButton;
        private DevComponents.DotNetBar.ButtonX bookHistoryButton;
        private DevComponents.DotNetBar.ButtonX memberHistoryButton;
        private MyControl.HolidayCalender.HolidayCalender holidayCalender;
        private DevComponents.DotNetBar.ButtonX sequenceButton;
    }
}