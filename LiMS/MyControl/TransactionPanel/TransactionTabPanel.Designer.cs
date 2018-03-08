namespace LiMS.MyControl.TransactionPanel
{
    partial class TransactionTabPanel
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
            this.memberPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.nameLabel = new System.Windows.Forms.Label();
            this.expireDateLabel = new System.Windows.Forms.Label();
            this.memberNoLabel = new System.Windows.Forms.Label();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new DevComponents.DotNetBar.ButtonX();
            this.searchIDTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.progressSteps1 = new DevComponents.DotNetBar.ProgressSteps();
            this.verifyStep = new DevComponents.DotNetBar.StepItem();
            this.returnStep = new DevComponents.DotNetBar.StepItem();
            this.borrowStep = new DevComponents.DotNetBar.StepItem();
            this.transactionPageSlider = new DevComponents.DotNetBar.Controls.PageSlider();
            this.verifyPage = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.bookIDRadioButton = new System.Windows.Forms.RadioButton();
            this.verifyNextButton = new DevComponents.DotNetBar.ButtonX();
            this.MemberIDRadioButton = new System.Windows.Forms.RadioButton();
            this.returnPage = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.returnPrevButton = new DevComponents.DotNetBar.ButtonX();
            this.returnNextButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.returnAllButton = new DevComponents.DotNetBar.ButtonX();
            this.returnFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.borrowPage = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.label3 = new System.Windows.Forms.Label();
            this.returnDatePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.finishButton = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.addBookNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.borrowFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addBookButton = new DevComponents.DotNetBar.ButtonX();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.memberPanel.SuspendLayout();
            this.transactionPageSlider.SuspendLayout();
            this.verifyPage.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.returnPage.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.borrowPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnDatePicker)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberPanel
            // 
            this.memberPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberPanel.Controls.Add(this.label2);
            this.memberPanel.Controls.Add(this.buttonX7);
            this.memberPanel.Controls.Add(this.nameLabel);
            this.memberPanel.Controls.Add(this.expireDateLabel);
            this.memberPanel.Controls.Add(this.memberNoLabel);
            this.memberPanel.Location = new System.Drawing.Point(395, 1);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(466, 80);
            this.memberPanel.TabIndex = 7;
            this.memberPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Renewal Date :";
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Location = new System.Drawing.Point(384, 47);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(75, 23);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX7.TabIndex = 0;
            this.buttonX7.Text = "Renew";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(124, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(337, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "පියුමාල් ජයමාල් චතුරිකා";
            // 
            // expireDateLabel
            // 
            this.expireDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expireDateLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDateLabel.Location = new System.Drawing.Point(120, 51);
            this.expireDateLabel.Name = "expireDateLabel";
            this.expireDateLabel.Size = new System.Drawing.Size(260, 19);
            this.expireDateLabel.TabIndex = 2;
            this.expireDateLabel.Text = "2016-01-12";
            // 
            // memberNoLabel
            // 
            this.memberNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNoLabel.Location = new System.Drawing.Point(2, 3);
            this.memberNoLabel.Name = "memberNoLabel";
            this.memberNoLabel.Size = new System.Drawing.Size(116, 30);
            this.memberNoLabel.TabIndex = 0;
            this.memberNoLabel.Text = "10626";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(170, 137);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(17, 17);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 13F;
            this.buttonX3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search From";
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(278, 12);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(40, 26);
            this.findButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findButton.Symbol = "";
            this.findButton.TabIndex = 1;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.AutoSelectAll = true;
            this.searchIDTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.searchIDTextBox.Border.Class = "TextBoxBorder";
            this.searchIDTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchIDTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.searchIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchIDTextBox.HideSelection = false;
            this.searchIDTextBox.Location = new System.Drawing.Point(18, 12);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(260, 26);
            this.searchIDTextBox.TabIndex = 0;
            this.searchIDTextBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.searchIDTextBox.WatermarkText = "Book ID";
            this.searchIDTextBox.TextChanged += new System.EventHandler(this.searchIDTextBox_TextChanged);
            this.searchIDTextBox.Enter += new System.EventHandler(this.searchIDTextBox_Enter);
            this.searchIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchIDTextBox_KeyDown);
            // 
            // progressSteps1
            // 
            // 
            // 
            // 
            this.progressSteps1.BackgroundStyle.Class = "ProgressSteps";
            this.progressSteps1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressSteps1.ContainerControlProcessDialogKey = true;
            this.progressSteps1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressSteps1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.verifyStep,
            this.returnStep,
            this.borrowStep});
            this.progressSteps1.Location = new System.Drawing.Point(0, 0);
            this.progressSteps1.Name = "progressSteps1";
            this.progressSteps1.Size = new System.Drawing.Size(864, 83);
            this.progressSteps1.TabIndex = 13;
            // 
            // verifyStep
            // 
            this.verifyStep.HotTracking = false;
            this.verifyStep.Name = "verifyStep";
            this.verifyStep.Symbol = "";
            this.verifyStep.SymbolSize = 30F;
            this.verifyStep.Text = "<h2><font color=\"#255663\">Verify</font></h2>\r\n<p>\r\nMember ID or\r\n<br></br>\r\nBook " +
    "ID\r\n</p>";
            this.verifyStep.Value = 100;
            // 
            // returnStep
            // 
            this.returnStep.HotTracking = false;
            this.returnStep.Name = "returnStep";
            this.returnStep.Symbol = "";
            this.returnStep.SymbolSize = 30F;
            this.returnStep.Text = "<h2><font color=\"#255663\">Return</font></h2>\r\n<p>\r\nReturn Books\r\n<br></br>\r\nFee C" +
    "ollect\r\n</p>";
            // 
            // borrowStep
            // 
            this.borrowStep.HotTracking = false;
            this.borrowStep.Name = "borrowStep";
            this.borrowStep.Symbol = "";
            this.borrowStep.SymbolSize = 30F;
            this.borrowStep.Text = "<h2><font color=\"#255663\">Borrow</font></h2>\r\n<p>\r\nBorrow Books\r\n<br></br>\r\nSave\r" +
    "\n</p>";
            // 
            // transactionPageSlider
            // 
            this.transactionPageSlider.AnimationTime = 150;
            this.transactionPageSlider.Controls.Add(this.verifyPage);
            this.transactionPageSlider.Controls.Add(this.returnPage);
            this.transactionPageSlider.Controls.Add(this.borrowPage);
            this.transactionPageSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionPageSlider.IndicatorVisible = false;
            this.transactionPageSlider.Location = new System.Drawing.Point(0, 83);
            this.transactionPageSlider.MouseDragEnabled = false;
            this.transactionPageSlider.Name = "transactionPageSlider";
            this.transactionPageSlider.NextPageVisibleMargin = 0;
            this.transactionPageSlider.PageMouseDragEnabled = false;
            this.transactionPageSlider.PageSpacing = 0;
            this.transactionPageSlider.ScrollBarVisibility = DevComponents.DotNetBar.Controls.eScrollBarVisibility.Hidden;
            this.transactionPageSlider.SelectedPage = this.verifyPage;
            this.transactionPageSlider.Size = new System.Drawing.Size(864, 433);
            this.transactionPageSlider.TabIndex = 0;
            this.transactionPageSlider.Text = "pageSlider1";
            this.transactionPageSlider.TouchEnabled = DevComponents.DotNetBar.Controls.eTouchHandling.No;
            this.transactionPageSlider.SelectedPageChanged += new System.EventHandler(this.transactionPageSlider_SelectedPageChanged);
            // 
            // verifyPage
            // 
            this.verifyPage.BackColor = System.Drawing.Color.White;
            this.verifyPage.Controls.Add(this.searchPanel);
            this.verifyPage.Controls.Add(this.buttonX3);
            this.verifyPage.Controls.Add(this.bookIDRadioButton);
            this.verifyPage.Controls.Add(this.label1);
            this.verifyPage.Controls.Add(this.verifyNextButton);
            this.verifyPage.Controls.Add(this.MemberIDRadioButton);
            this.verifyPage.Location = new System.Drawing.Point(4, 4);
            this.verifyPage.Name = "verifyPage";
            this.verifyPage.Size = new System.Drawing.Size(856, 425);
            this.verifyPage.TabIndex = 0;
            this.verifyPage.Resize += new System.EventHandler(this.verifyPage_Resize);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchIDTextBox);
            this.searchPanel.Controls.Add(this.findButton);
            this.searchPanel.Location = new System.Drawing.Point(262, 211);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(339, 48);
            this.searchPanel.TabIndex = 0;
            // 
            // bookIDRadioButton
            // 
            this.bookIDRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.bookIDRadioButton.Checked = true;
            this.bookIDRadioButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookIDRadioButton.FlatAppearance.BorderSize = 0;
            this.bookIDRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(150)))), ((int)(((byte)(178)))));
            this.bookIDRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIDRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDRadioButton.Image = global::LiMS.Properties.Resources.book;
            this.bookIDRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookIDRadioButton.Location = new System.Drawing.Point(40, 39);
            this.bookIDRadioButton.Name = "bookIDRadioButton";
            this.bookIDRadioButton.Size = new System.Drawing.Size(147, 43);
            this.bookIDRadioButton.TabIndex = 3;
            this.bookIDRadioButton.TabStop = true;
            this.bookIDRadioButton.Text = "&Book ID";
            this.bookIDRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookIDRadioButton.UseVisualStyleBackColor = false;
            this.bookIDRadioButton.CheckedChanged += new System.EventHandler(this.bookIDRadioButton_CheckedChanged);
            // 
            // verifyNextButton
            // 
            this.verifyNextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.verifyNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.verifyNextButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.verifyNextButton.Location = new System.Drawing.Point(775, 390);
            this.verifyNextButton.Name = "verifyNextButton";
            this.verifyNextButton.Size = new System.Drawing.Size(75, 32);
            this.verifyNextButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.verifyNextButton.Symbol = "";
            this.verifyNextButton.TabIndex = 1;
            this.verifyNextButton.Click += new System.EventHandler(this.verifyNextButton_Click);
            // 
            // MemberIDRadioButton
            // 
            this.MemberIDRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MemberIDRadioButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MemberIDRadioButton.FlatAppearance.BorderSize = 0;
            this.MemberIDRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(150)))), ((int)(((byte)(178)))));
            this.MemberIDRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberIDRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDRadioButton.Image = global::LiMS.Properties.Resources.user;
            this.MemberIDRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberIDRadioButton.Location = new System.Drawing.Point(40, 88);
            this.MemberIDRadioButton.Name = "MemberIDRadioButton";
            this.MemberIDRadioButton.Size = new System.Drawing.Size(147, 43);
            this.MemberIDRadioButton.TabIndex = 4;
            this.MemberIDRadioButton.Text = "&Member ID";
            this.MemberIDRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MemberIDRadioButton.UseVisualStyleBackColor = false;
            this.MemberIDRadioButton.CheckedChanged += new System.EventHandler(this.MemberIDRadioButton_CheckedChanged);
            // 
            // returnPage
            // 
            this.returnPage.BackColor = System.Drawing.SystemColors.Window;
            this.returnPage.Controls.Add(this.returnPrevButton);
            this.returnPage.Controls.Add(this.returnNextButton);
            this.returnPage.Controls.Add(this.groupPanel1);
            this.returnPage.Location = new System.Drawing.Point(860, 4);
            this.returnPage.Name = "returnPage";
            this.returnPage.Size = new System.Drawing.Size(856, 425);
            this.returnPage.TabIndex = 3;
            // 
            // returnPrevButton
            // 
            this.returnPrevButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.returnPrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnPrevButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.returnPrevButton.Location = new System.Drawing.Point(734, 390);
            this.returnPrevButton.Name = "returnPrevButton";
            this.returnPrevButton.Size = new System.Drawing.Size(38, 32);
            this.returnPrevButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnPrevButton.Symbol = "";
            this.returnPrevButton.TabIndex = 10;
            this.returnPrevButton.Click += new System.EventHandler(this.returnPrevButton_Click);
            // 
            // returnNextButton
            // 
            this.returnNextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.returnNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnNextButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.returnNextButton.Location = new System.Drawing.Point(776, 390);
            this.returnNextButton.Name = "returnNextButton";
            this.returnNextButton.Size = new System.Drawing.Size(75, 32);
            this.returnNextButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnNextButton.Symbol = "";
            this.returnNextButton.TabIndex = 9;
            this.returnNextButton.Click += new System.EventHandler(this.returnNextButton_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.returnAllButton);
            this.groupPanel1.Controls.Add(this.returnFlowLayout);
            this.groupPanel1.Controls.Add(this.buttonX9);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(8, 9);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(842, 375);
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
            this.groupPanel1.TabIndex = 8;
            this.groupPanel1.Text = "Return";
            // 
            // returnAllButton
            // 
            this.returnAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.returnAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.returnAllButton.Location = new System.Drawing.Point(3, 3);
            this.returnAllButton.Name = "returnAllButton";
            this.returnAllButton.Size = new System.Drawing.Size(75, 23);
            this.returnAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnAllButton.TabIndex = 1;
            this.returnAllButton.Text = "Return All";
            this.returnAllButton.Click += new System.EventHandler(this.returnAllButton_Click);
            // 
            // returnFlowLayout
            // 
            this.returnFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnFlowLayout.AutoScroll = true;
            this.returnFlowLayout.BackColor = System.Drawing.SystemColors.Window;
            this.returnFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnFlowLayout.Location = new System.Drawing.Point(3, 32);
            this.returnFlowLayout.Name = "returnFlowLayout";
            this.returnFlowLayout.Size = new System.Drawing.Size(830, 319);
            this.returnFlowLayout.TabIndex = 0;
            this.returnFlowLayout.Resize += new System.EventHandler(this.returnBorrowFlowLayout_Resize);
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(83, 3);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(75, 23);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 2;
            this.buttonX9.Text = "Pay Fine";
            // 
            // borrowPage
            // 
            this.borrowPage.BackColor = System.Drawing.Color.White;
            this.borrowPage.Controls.Add(this.label3);
            this.borrowPage.Controls.Add(this.returnDatePicker);
            this.borrowPage.Controls.Add(this.finishButton);
            this.borrowPage.Controls.Add(this.groupPanel2);
            this.borrowPage.Location = new System.Drawing.Point(1716, 4);
            this.borrowPage.Name = "borrowPage";
            this.borrowPage.Size = new System.Drawing.Size(856, 425);
            this.borrowPage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Return Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.returnDatePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.returnDatePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.returnDatePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.returnDatePicker.ButtonDropDown.Visible = true;
            this.returnDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDatePicker.IsPopupCalendarOpen = false;
            this.returnDatePicker.Location = new System.Drawing.Point(539, 388);
            // 
            // 
            // 
            this.returnDatePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.returnDatePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.returnDatePicker.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.returnDatePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.returnDatePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.returnDatePicker.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.returnDatePicker.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.returnDatePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.returnDatePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.returnDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.returnDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.returnDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.returnDatePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.returnDatePicker.MonthCalendar.TodayButtonVisible = true;
            this.returnDatePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(200, 26);
            this.returnDatePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnDatePicker.TabIndex = 11;
            // 
            // finishButton
            // 
            this.finishButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.finishButton.Location = new System.Drawing.Point(771, 384);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 32);
            this.finishButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.finishButton.Symbol = "";
            this.finishButton.TabIndex = 10;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.addBookNoTextBox);
            this.groupPanel2.Controls.Add(this.borrowFlowLayout);
            this.groupPanel2.Controls.Add(this.addBookButton);
            this.groupPanel2.Controls.Add(this.buttonX12);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(6, 9);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(840, 369);
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
            this.groupPanel2.TabIndex = 8;
            this.groupPanel2.Text = "Borrow";
            // 
            // addBookNoTextBox
            // 
            this.addBookNoTextBox.AutoSelectAll = true;
            this.addBookNoTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.addBookNoTextBox.Border.Class = "TextBoxBorder";
            this.addBookNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addBookNoTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.addBookNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.addBookNoTextBox.HideSelection = false;
            this.addBookNoTextBox.Location = new System.Drawing.Point(3, 5);
            this.addBookNoTextBox.Name = "addBookNoTextBox";
            this.addBookNoTextBox.Size = new System.Drawing.Size(216, 26);
            this.addBookNoTextBox.TabIndex = 4;
            this.addBookNoTextBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.addBookNoTextBox.WatermarkText = "Book ID";
            this.addBookNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addBookNoTextBox_KeyDown);
            // 
            // borrowFlowLayout
            // 
            this.borrowFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowFlowLayout.AutoScroll = true;
            this.borrowFlowLayout.BackColor = System.Drawing.SystemColors.Window;
            this.borrowFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borrowFlowLayout.Location = new System.Drawing.Point(2, 34);
            this.borrowFlowLayout.Name = "borrowFlowLayout";
            this.borrowFlowLayout.Size = new System.Drawing.Size(829, 311);
            this.borrowFlowLayout.TabIndex = 1;
            this.borrowFlowLayout.Resize += new System.EventHandler(this.returnBorrowFlowLayout_Resize);
            // 
            // addBookButton
            // 
            this.addBookButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addBookButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addBookButton.Location = new System.Drawing.Point(225, 5);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.addBookButton.Size = new System.Drawing.Size(40, 26);
            this.addBookButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addBookButton.Symbol = "";
            this.addBookButton.TabIndex = 3;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX12.Location = new System.Drawing.Point(756, 5);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Size = new System.Drawing.Size(75, 23);
            this.buttonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX12.TabIndex = 2;
            this.buttonX12.Text = "Clean List";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.memberPanel);
            this.panelEx1.Controls.Add(this.transactionPageSlider);
            this.panelEx1.Controls.Add(this.progressSteps1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(864, 516);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 15;
            this.panelEx1.Text = "panelEx1";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // TransactionTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panelEx1);
            this.Name = "TransactionTabPanel";
            this.Size = new System.Drawing.Size(864, 516);
            this.Enter += new System.EventHandler(this.LendingTabPanel_Enter);
            this.memberPanel.ResumeLayout(false);
            this.transactionPageSlider.ResumeLayout(false);
            this.verifyPage.ResumeLayout(false);
            this.verifyPage.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.returnPage.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.borrowPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnDatePicker)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX searchIDTextBox;
        private DevComponents.DotNetBar.ButtonX findButton;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MemberIDRadioButton;
        private System.Windows.Forms.RadioButton bookIDRadioButton;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label memberNoLabel;
        private System.Windows.Forms.Label expireDateLabel;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.ProgressSteps progressSteps1;
        private DevComponents.DotNetBar.StepItem verifyStep;
        private DevComponents.DotNetBar.StepItem returnStep;
        private DevComponents.DotNetBar.StepItem borrowStep;
        private DevComponents.DotNetBar.Controls.PageSlider transactionPageSlider;
        private DevComponents.DotNetBar.Controls.PageSliderPage verifyPage;
        private DevComponents.DotNetBar.ButtonX verifyNextButton;
        private DevComponents.DotNetBar.Controls.PageSliderPage returnPage;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX returnAllButton;
        private System.Windows.Forms.FlowLayoutPanel returnFlowLayout;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.Controls.PageSliderPage borrowPage;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX addBookNoTextBox;
        private System.Windows.Forms.FlowLayoutPanel borrowFlowLayout;
        private DevComponents.DotNetBar.ButtonX addBookButton;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private DevComponents.DotNetBar.ButtonX returnNextButton;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel searchPanel;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX finishButton;
        private DevComponents.DotNetBar.ButtonX returnPrevButton;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput returnDatePicker;

    }
}
