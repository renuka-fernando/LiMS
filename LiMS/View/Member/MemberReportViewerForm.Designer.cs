namespace LiMS.View.Member
{
    partial class MemberReportViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberReportViewerForm));
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.filterButton = new DevComponents.DotNetBar.ButtonX();
            this.filterSortSlidePanel = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.suretyNameComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.memberIDComboBox = new System.Windows.Forms.ComboBox();
            this.suretyNameRadioButton = new System.Windows.Forms.RadioButton();
            this.ageRadioButton = new System.Windows.Forms.RadioButton();
            this.memberIDRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.customPanel = new DevComponents.DotNetBar.PanelEx();
            this.feeRangePanel = new DevComponents.DotNetBar.PanelEx();
            this.feeRangeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.priceDoubleInput = new DevComponents.Editors.DoubleInput();
            this.topPanel = new DevComponents.DotNetBar.PanelEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.topRowsIntInput = new DevComponents.Editors.IntegerInput();
            this.topRowsCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.feeRangeCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.notReturnedCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.notPaidCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.applyButton = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.filterSortSlidePanel.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.customPanel.SuspendLayout();
            this.feeRangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDoubleInput)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRowsIntInput)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BackColor = System.Drawing.Color.White;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.ForeColor = System.Drawing.Color.Black;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 40);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(869, 492);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.filterButton);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(869, 40);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // filterButton
            // 
            this.filterButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filterButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(1, 3);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(214, 34);
            this.filterButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.filterButton.Symbol = "";
            this.filterButton.TabIndex = 0;
            this.filterButton.Text = "&Filter && Sort Members";
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterSortSlidePanel
            // 
            this.filterSortSlidePanel.BackColor = System.Drawing.Color.White;
            this.filterSortSlidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSortSlidePanel.Controls.Add(this.groupPanel2);
            this.filterSortSlidePanel.Controls.Add(this.groupPanel1);
            this.filterSortSlidePanel.Controls.Add(this.applyButton);
            this.filterSortSlidePanel.ForeColor = System.Drawing.Color.Black;
            this.filterSortSlidePanel.Location = new System.Drawing.Point(1, 40);
            this.filterSortSlidePanel.Name = "filterSortSlidePanel";
            this.filterSortSlidePanel.Size = new System.Drawing.Size(467, 480);
            this.filterSortSlidePanel.SlideOutButtonVisible = false;
            this.filterSortSlidePanel.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Top;
            this.filterSortSlidePanel.TabIndex = 2;
            this.filterSortSlidePanel.Text = "slidePanel1";
            this.filterSortSlidePanel.UsesBlockingAnimation = false;
            this.filterSortSlidePanel.IsOpenChanged += new System.EventHandler(this.filterSlidePanel_IsOpenChanged);
            this.filterSortSlidePanel.Leave += new System.EventHandler(this.filterSlidePanel_Leave);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.suretyNameComboBox);
            this.groupPanel2.Controls.Add(this.ageComboBox);
            this.groupPanel2.Controls.Add(this.nameComboBox);
            this.groupPanel2.Controls.Add(this.memberIDComboBox);
            this.groupPanel2.Controls.Add(this.suretyNameRadioButton);
            this.groupPanel2.Controls.Add(this.ageRadioButton);
            this.groupPanel2.Controls.Add(this.memberIDRadioButton);
            this.groupPanel2.Controls.Add(this.nameRadioButton);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 292);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(458, 151);
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
            this.groupPanel2.TabIndex = 6;
            this.groupPanel2.Text = "Sort";
            // 
            // suretyNameComboBox
            // 
            this.suretyNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suretyNameComboBox.Enabled = false;
            this.suretyNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suretyNameComboBox.FormattingEnabled = true;
            this.suretyNameComboBox.Items.AddRange(new object[] {
            "1 -> 9",
            "9 -> 1"});
            this.suretyNameComboBox.Location = new System.Drawing.Point(214, 95);
            this.suretyNameComboBox.Name = "suretyNameComboBox";
            this.suretyNameComboBox.Size = new System.Drawing.Size(115, 29);
            this.suretyNameComboBox.TabIndex = 10;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageComboBox.Enabled = false;
            this.ageComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "1 -> 9",
            "9 -> 1"});
            this.ageComboBox.Location = new System.Drawing.Point(214, 64);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(115, 29);
            this.ageComboBox.TabIndex = 9;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Enabled = false;
            this.nameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Items.AddRange(new object[] {
            "1 -> 9",
            "9 -> 1"});
            this.nameComboBox.Location = new System.Drawing.Point(214, 33);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(115, 29);
            this.nameComboBox.TabIndex = 8;
            // 
            // memberIDComboBox
            // 
            this.memberIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberIDComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDComboBox.FormattingEnabled = true;
            this.memberIDComboBox.Items.AddRange(new object[] {
            "1 -> 9",
            "9 -> 1"});
            this.memberIDComboBox.Location = new System.Drawing.Point(214, 2);
            this.memberIDComboBox.Name = "memberIDComboBox";
            this.memberIDComboBox.Size = new System.Drawing.Size(115, 29);
            this.memberIDComboBox.TabIndex = 7;
            // 
            // suretyNameRadioButton
            // 
            this.suretyNameRadioButton.BackColor = System.Drawing.Color.White;
            this.suretyNameRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suretyNameRadioButton.ForeColor = System.Drawing.Color.Black;
            this.suretyNameRadioButton.Location = new System.Drawing.Point(7, 96);
            this.suretyNameRadioButton.Name = "suretyNameRadioButton";
            this.suretyNameRadioButton.Size = new System.Drawing.Size(184, 25);
            this.suretyNameRadioButton.TabIndex = 5;
            this.suretyNameRadioButton.Text = "&Surety Name";
            this.suretyNameRadioButton.UseVisualStyleBackColor = false;
            this.suretyNameRadioButton.CheckedChanged += new System.EventHandler(this.suretyNameRadioButton_CheckedChanged);
            // 
            // ageRadioButton
            // 
            this.ageRadioButton.BackColor = System.Drawing.Color.White;
            this.ageRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ageRadioButton.Location = new System.Drawing.Point(7, 65);
            this.ageRadioButton.Name = "ageRadioButton";
            this.ageRadioButton.Size = new System.Drawing.Size(184, 25);
            this.ageRadioButton.TabIndex = 4;
            this.ageRadioButton.Text = "Member A&ge";
            this.ageRadioButton.UseVisualStyleBackColor = false;
            this.ageRadioButton.CheckedChanged += new System.EventHandler(this.ageRadioButton_CheckedChanged);
            // 
            // memberIDRadioButton
            // 
            this.memberIDRadioButton.BackColor = System.Drawing.Color.White;
            this.memberIDRadioButton.Checked = true;
            this.memberIDRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDRadioButton.ForeColor = System.Drawing.Color.Black;
            this.memberIDRadioButton.Location = new System.Drawing.Point(7, 3);
            this.memberIDRadioButton.Name = "memberIDRadioButton";
            this.memberIDRadioButton.Size = new System.Drawing.Size(184, 25);
            this.memberIDRadioButton.TabIndex = 2;
            this.memberIDRadioButton.TabStop = true;
            this.memberIDRadioButton.Text = "Member &ID";
            this.memberIDRadioButton.UseVisualStyleBackColor = false;
            this.memberIDRadioButton.CheckedChanged += new System.EventHandler(this.memberIDRadioButton_CheckedChanged);
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.BackColor = System.Drawing.Color.White;
            this.nameRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRadioButton.ForeColor = System.Drawing.Color.Black;
            this.nameRadioButton.Location = new System.Drawing.Point(7, 34);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(184, 25);
            this.nameRadioButton.TabIndex = 3;
            this.nameRadioButton.Text = "Member &Name";
            this.nameRadioButton.UseVisualStyleBackColor = false;
            this.nameRadioButton.CheckedChanged += new System.EventHandler(this.nameRadioButton_CheckedChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.allRadioButton);
            this.groupPanel1.Controls.Add(this.customRadioButton);
            this.groupPanel1.Controls.Add(this.customPanel);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(458, 283);
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
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "Filter";
            // 
            // allRadioButton
            // 
            this.allRadioButton.BackColor = System.Drawing.Color.White;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioButton.ForeColor = System.Drawing.Color.Black;
            this.allRadioButton.Location = new System.Drawing.Point(7, 3);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(184, 25);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All &Members";
            this.allRadioButton.UseVisualStyleBackColor = false;
            // 
            // customRadioButton
            // 
            this.customRadioButton.BackColor = System.Drawing.Color.White;
            this.customRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRadioButton.ForeColor = System.Drawing.Color.Black;
            this.customRadioButton.Location = new System.Drawing.Point(7, 34);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(184, 25);
            this.customRadioButton.TabIndex = 1;
            this.customRadioButton.Text = "&Custom";
            this.customRadioButton.UseVisualStyleBackColor = false;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.customRadioButton_CheckedChanged);
            // 
            // customPanel
            // 
            this.customPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.customPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.customPanel.Controls.Add(this.feeRangePanel);
            this.customPanel.Controls.Add(this.topPanel);
            this.customPanel.Controls.Add(this.topRowsCheckBox);
            this.customPanel.Controls.Add(this.feeRangeCheckBox);
            this.customPanel.Controls.Add(this.notReturnedCheckBox);
            this.customPanel.Controls.Add(this.notPaidCheckBox);
            this.customPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.customPanel.Enabled = false;
            this.customPanel.Location = new System.Drawing.Point(25, 65);
            this.customPanel.Name = "customPanel";
            this.customPanel.Size = new System.Drawing.Size(424, 187);
            this.customPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.customPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.customPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.customPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.customPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.customPanel.Style.GradientAngle = 90;
            this.customPanel.TabIndex = 4;
            // 
            // feeRangePanel
            // 
            this.feeRangePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.feeRangePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.feeRangePanel.Controls.Add(this.feeRangeTypeComboBox);
            this.feeRangePanel.Controls.Add(this.priceDoubleInput);
            this.feeRangePanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.feeRangePanel.Enabled = false;
            this.feeRangePanel.Location = new System.Drawing.Point(189, 105);
            this.feeRangePanel.Name = "feeRangePanel";
            this.feeRangePanel.Size = new System.Drawing.Size(232, 29);
            this.feeRangePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.feeRangePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.feeRangePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.feeRangePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.feeRangePanel.Style.GradientAngle = 90;
            this.feeRangePanel.TabIndex = 6;
            // 
            // feeRangeTypeComboBox
            // 
            this.feeRangeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feeRangeTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeRangeTypeComboBox.FormattingEnabled = true;
            this.feeRangeTypeComboBox.Items.AddRange(new object[] {
            "less than",
            "larger than"});
            this.feeRangeTypeComboBox.Location = new System.Drawing.Point(0, 0);
            this.feeRangeTypeComboBox.Name = "feeRangeTypeComboBox";
            this.feeRangeTypeComboBox.Size = new System.Drawing.Size(115, 29);
            this.feeRangeTypeComboBox.TabIndex = 6;
            // 
            // priceDoubleInput
            // 
            this.priceDoubleInput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.priceDoubleInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.priceDoubleInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.priceDoubleInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.priceDoubleInput.DisplayFormat = "0.00";
            this.priceDoubleInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDoubleInput.ForeColor = System.Drawing.Color.Black;
            this.priceDoubleInput.Increment = 1D;
            this.priceDoubleInput.Location = new System.Drawing.Point(121, 0);
            this.priceDoubleInput.MaxValue = 99999D;
            this.priceDoubleInput.MinValue = 0D;
            this.priceDoubleInput.Name = "priceDoubleInput";
            this.priceDoubleInput.Size = new System.Drawing.Size(106, 29);
            this.priceDoubleInput.TabIndex = 7;
            this.priceDoubleInput.Value = 50D;
            // 
            // topPanel
            // 
            this.topPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.topPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.topPanel.Controls.Add(this.labelX4);
            this.topPanel.Controls.Add(this.topRowsIntInput);
            this.topPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.topPanel.Enabled = false;
            this.topPanel.Location = new System.Drawing.Point(189, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(232, 29);
            this.topPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.topPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.topPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.topPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.topPanel.Style.GradientAngle = 90;
            this.topPanel.TabIndex = 5;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(121, 0);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(106, 29);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "only";
            // 
            // topRowsIntInput
            // 
            this.topRowsIntInput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.topRowsIntInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.topRowsIntInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.topRowsIntInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.topRowsIntInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.topRowsIntInput.ForeColor = System.Drawing.Color.Black;
            this.topRowsIntInput.Location = new System.Drawing.Point(0, 0);
            this.topRowsIntInput.MinValue = 1;
            this.topRowsIntInput.Name = "topRowsIntInput";
            this.topRowsIntInput.Size = new System.Drawing.Size(115, 29);
            this.topRowsIntInput.TabIndex = 1;
            this.topRowsIntInput.Value = 50;
            // 
            // topRowsCheckBox
            // 
            // 
            // 
            // 
            this.topRowsCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.topRowsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRowsCheckBox.ForeColor = System.Drawing.Color.Black;
            this.topRowsCheckBox.Location = new System.Drawing.Point(3, 3);
            this.topRowsCheckBox.Name = "topRowsCheckBox";
            this.topRowsCheckBox.Size = new System.Drawing.Size(180, 29);
            this.topRowsCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.topRowsCheckBox.TabIndex = 0;
            this.topRowsCheckBox.Text = "Select &Top";
            this.topRowsCheckBox.CheckedChanged += new System.EventHandler(this.topRowsCheckBox_CheckedChanged);
            // 
            // feeRangeCheckBox
            // 
            // 
            // 
            // 
            this.feeRangeCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.feeRangeCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeRangeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.feeRangeCheckBox.Location = new System.Drawing.Point(3, 105);
            this.feeRangeCheckBox.Name = "feeRangeCheckBox";
            this.feeRangeCheckBox.Size = new System.Drawing.Size(180, 29);
            this.feeRangeCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.feeRangeCheckBox.TabIndex = 5;
            this.feeRangeCheckBox.Text = "Fee Ra&nge";
            this.feeRangeCheckBox.CheckedChanged += new System.EventHandler(this.feeRangeCheckBox_CheckedChanged);
            // 
            // notReturnedCheckBox
            // 
            // 
            // 
            // 
            this.notReturnedCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.notReturnedCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notReturnedCheckBox.ForeColor = System.Drawing.Color.Black;
            this.notReturnedCheckBox.Location = new System.Drawing.Point(3, 35);
            this.notReturnedCheckBox.Name = "notReturnedCheckBox";
            this.notReturnedCheckBox.Size = new System.Drawing.Size(180, 29);
            this.notReturnedCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.notReturnedCheckBox.TabIndex = 3;
            this.notReturnedCheckBox.Text = "Books Not &Returned";
            // 
            // notPaidCheckBox
            // 
            // 
            // 
            // 
            this.notPaidCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.notPaidCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notPaidCheckBox.ForeColor = System.Drawing.Color.Black;
            this.notPaidCheckBox.Location = new System.Drawing.Point(3, 70);
            this.notPaidCheckBox.Name = "notPaidCheckBox";
            this.notPaidCheckBox.Size = new System.Drawing.Size(180, 29);
            this.notPaidCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.notPaidCheckBox.TabIndex = 4;
            this.notPaidCheckBox.Text = "Fees Not &Paid";
            // 
            // applyButton
            // 
            this.applyButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.applyButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(365, 449);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(96, 23);
            this.applyButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "&Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // MemberReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 532);
            this.Controls.Add(this.filterSortSlidePanel);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberReportViewerForm_Load);
            this.panelEx1.ResumeLayout(false);
            this.filterSortSlidePanel.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.customPanel.ResumeLayout(false);
            this.feeRangePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceDoubleInput)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topRowsIntInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX filterButton;
        private DevComponents.DotNetBar.Controls.SlidePanel filterSortSlidePanel;
        private DevComponents.DotNetBar.ButtonX applyButton;
        private DevComponents.DotNetBar.PanelEx customPanel;
        private DevComponents.DotNetBar.Controls.CheckBoxX notReturnedCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX notPaidCheckBox;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX feeRangeCheckBox;
        private System.Windows.Forms.ComboBox feeRangeTypeComboBox;
        private DevComponents.Editors.DoubleInput priceDoubleInput;
        private DevComponents.DotNetBar.Controls.CheckBoxX topRowsCheckBox;
        private DevComponents.Editors.IntegerInput topRowsIntInput;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.RadioButton suretyNameRadioButton;
        private System.Windows.Forms.RadioButton ageRadioButton;
        private System.Windows.Forms.RadioButton memberIDRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.ComboBox suretyNameComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox memberIDComboBox;
        private DevComponents.DotNetBar.PanelEx feeRangePanel;
        private DevComponents.DotNetBar.PanelEx topPanel;
    }
}