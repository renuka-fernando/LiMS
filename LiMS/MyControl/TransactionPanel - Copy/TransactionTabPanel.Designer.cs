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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.bookIDRadioButton = new System.Windows.Forms.RadioButton();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.MemberIDRadioButton = new System.Windows.Forms.RadioButton();
            this.findButton = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.borrowGroupBox = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.borrowCollapseButton = new DevComponents.DotNetBar.ButtonX();
            this.addBookIDTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.borrowFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.clearBorrowButton = new DevComponents.DotNetBar.ButtonX();
            this.returnGroupBox = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.returnAllButton = new DevComponents.DotNetBar.ButtonX();
            this.returnCollapseButton = new DevComponents.DotNetBar.ButtonX();
            this.returnFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.borrowGroupBox.SuspendLayout();
            this.returnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.searchPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonX7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(352, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 75);
            this.panel3.TabIndex = 8;
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Location = new System.Drawing.Point(419, 47);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(75, 23);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX7.TabIndex = 3;
            this.buttonX7.Text = "Renew";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "පියුමාල් ජයමාල් චතුරිකා";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Renewal Date : 2016-01-12";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "10626";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.Window;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.bookIDRadioButton);
            this.searchPanel.Controls.Add(this.buttonX3);
            this.searchPanel.Controls.Add(this.MemberIDRadioButton);
            this.searchPanel.Controls.Add(this.findButton);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.searchIDTextBox);
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(345, 75);
            this.searchPanel.TabIndex = 7;
            // 
            // bookIDRadioButton
            // 
            this.bookIDRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.bookIDRadioButton.Checked = true;
            this.bookIDRadioButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookIDRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.bookIDRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookIDRadioButton.Location = new System.Drawing.Point(5, 24);
            this.bookIDRadioButton.Name = "bookIDRadioButton";
            this.bookIDRadioButton.Size = new System.Drawing.Size(37, 43);
            this.bookIDRadioButton.TabIndex = 0;
            this.bookIDRadioButton.TabStop = true;
            this.bookIDRadioButton.UseVisualStyleBackColor = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(323, 53);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(17, 17);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 12F;
            this.buttonX3.TabIndex = 4;
            // 
            // MemberIDRadioButton
            // 
            this.MemberIDRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MemberIDRadioButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MemberIDRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.MemberIDRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberIDRadioButton.Location = new System.Drawing.Point(42, 24);
            this.MemberIDRadioButton.Name = "MemberIDRadioButton";
            this.MemberIDRadioButton.Size = new System.Drawing.Size(37, 43);
            this.MemberIDRadioButton.TabIndex = 1;
            this.MemberIDRadioButton.UseVisualStyleBackColor = false;
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(300, 24);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(40, 23);
            this.findButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findButton.Symbol = "";
            this.findButton.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search From";
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
            this.searchIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchIDTextBox.HideSelection = false;
            this.searchIDTextBox.Location = new System.Drawing.Point(85, 24);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(216, 23);
            this.searchIDTextBox.TabIndex = 2;
            this.searchIDTextBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.searchIDTextBox.WatermarkText = "Book ID";
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.borrowGroupBox, 0, 1);
            this.tableLayout.Controls.Add(this.returnGroupBox, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 92);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(856, 458);
            this.tableLayout.TabIndex = 11;
            // 
            // borrowGroupBox
            // 
            this.borrowGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowGroupBox.CanvasColor = System.Drawing.SystemColors.Control;
            this.borrowGroupBox.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.borrowGroupBox.Controls.Add(this.borrowCollapseButton);
            this.borrowGroupBox.Controls.Add(this.addBookIDTextBox);
            this.borrowGroupBox.Controls.Add(this.borrowFlowLayout);
            this.borrowGroupBox.Controls.Add(this.buttonX8);
            this.borrowGroupBox.Controls.Add(this.clearBorrowButton);
            this.borrowGroupBox.DisabledBackColor = System.Drawing.Color.Empty;
            this.borrowGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowGroupBox.Location = new System.Drawing.Point(3, 232);
            this.borrowGroupBox.Name = "borrowGroupBox";
            this.borrowGroupBox.Size = new System.Drawing.Size(850, 223);
            // 
            // 
            // 
            this.borrowGroupBox.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.borrowGroupBox.Style.BackColorGradientAngle = 90;
            this.borrowGroupBox.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.borrowGroupBox.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.borrowGroupBox.Style.BorderBottomWidth = 1;
            this.borrowGroupBox.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.borrowGroupBox.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.borrowGroupBox.Style.BorderLeftWidth = 1;
            this.borrowGroupBox.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.borrowGroupBox.Style.BorderRightWidth = 1;
            this.borrowGroupBox.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.borrowGroupBox.Style.BorderTopWidth = 1;
            this.borrowGroupBox.Style.CornerDiameter = 4;
            this.borrowGroupBox.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.borrowGroupBox.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.borrowGroupBox.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.borrowGroupBox.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.borrowGroupBox.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.borrowGroupBox.TabIndex = 7;
            this.borrowGroupBox.Text = "Borrow";
            // 
            // borrowCollapseButton
            // 
            this.borrowCollapseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.borrowCollapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowCollapseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.borrowCollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowCollapseButton.Location = new System.Drawing.Point(812, 5);
            this.borrowCollapseButton.Name = "borrowCollapseButton";
            this.borrowCollapseButton.Size = new System.Drawing.Size(22, 23);
            this.borrowCollapseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.borrowCollapseButton.SymbolSize = 10F;
            this.borrowCollapseButton.TabIndex = 5;
            this.borrowCollapseButton.Text = "-";
            // 
            // addBookIDTextBox
            // 
            this.addBookIDTextBox.AutoSelectAll = true;
            this.addBookIDTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.addBookIDTextBox.Border.Class = "TextBoxBorder";
            this.addBookIDTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addBookIDTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.addBookIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.addBookIDTextBox.HideSelection = false;
            this.addBookIDTextBox.Location = new System.Drawing.Point(3, 5);
            this.addBookIDTextBox.Name = "addBookIDTextBox";
            this.addBookIDTextBox.Size = new System.Drawing.Size(216, 23);
            this.addBookIDTextBox.TabIndex = 4;
            this.addBookIDTextBox.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.addBookIDTextBox.WatermarkText = "Book ID";
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
            this.borrowFlowLayout.Size = new System.Drawing.Size(833, 144);
            this.borrowFlowLayout.TabIndex = 1;
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Location = new System.Drawing.Point(218, 5);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.buttonX8.Size = new System.Drawing.Size(40, 23);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.Symbol = "";
            this.buttonX8.TabIndex = 3;
            // 
            // clearBorrowButton
            // 
            this.clearBorrowButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.clearBorrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBorrowButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.clearBorrowButton.Location = new System.Drawing.Point(731, 5);
            this.clearBorrowButton.Name = "clearBorrowButton";
            this.clearBorrowButton.Size = new System.Drawing.Size(75, 23);
            this.clearBorrowButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.clearBorrowButton.TabIndex = 2;
            this.clearBorrowButton.Text = "Clean List";
            // 
            // returnGroupBox
            // 
            this.returnGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.returnGroupBox.CanvasColor = System.Drawing.SystemColors.Control;
            this.returnGroupBox.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.returnGroupBox.Controls.Add(this.returnAllButton);
            this.returnGroupBox.Controls.Add(this.returnCollapseButton);
            this.returnGroupBox.Controls.Add(this.returnFlowLayout);
            this.returnGroupBox.Controls.Add(this.buttonX4);
            this.returnGroupBox.DisabledBackColor = System.Drawing.Color.Empty;
            this.returnGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnGroupBox.Location = new System.Drawing.Point(3, 3);
            this.returnGroupBox.Name = "returnGroupBox";
            this.returnGroupBox.Size = new System.Drawing.Size(850, 223);
            // 
            // 
            // 
            this.returnGroupBox.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.returnGroupBox.Style.BackColorGradientAngle = 90;
            this.returnGroupBox.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.returnGroupBox.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.returnGroupBox.Style.BorderBottomWidth = 1;
            this.returnGroupBox.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.returnGroupBox.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.returnGroupBox.Style.BorderLeftWidth = 1;
            this.returnGroupBox.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.returnGroupBox.Style.BorderRightWidth = 1;
            this.returnGroupBox.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.returnGroupBox.Style.BorderTopWidth = 1;
            this.returnGroupBox.Style.CornerDiameter = 4;
            this.returnGroupBox.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.returnGroupBox.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.returnGroupBox.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.returnGroupBox.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.returnGroupBox.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.returnGroupBox.TabIndex = 7;
            this.returnGroupBox.Text = "Return";
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
            // 
            // returnCollapseButton
            // 
            this.returnCollapseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.returnCollapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnCollapseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.returnCollapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCollapseButton.Location = new System.Drawing.Point(813, 3);
            this.returnCollapseButton.Name = "returnCollapseButton";
            this.returnCollapseButton.Size = new System.Drawing.Size(22, 23);
            this.returnCollapseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnCollapseButton.SymbolSize = 10F;
            this.returnCollapseButton.TabIndex = 6;
            this.returnCollapseButton.Text = "-";
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
            this.returnFlowLayout.Size = new System.Drawing.Size(831, 146);
            this.returnFlowLayout.TabIndex = 0;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(83, 3);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 2;
            this.buttonX4.Text = "Pay Fine";
            // 
            // TransactionTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionTabPanel";
            this.Size = new System.Drawing.Size(856, 550);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.borrowGroupBox.ResumeLayout(false);
            this.returnGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.RadioButton bookIDRadioButton;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.RadioButton MemberIDRadioButton;
        private DevComponents.DotNetBar.ButtonX findButton;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX searchIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private DevComponents.DotNetBar.Controls.GroupPanel borrowGroupBox;
        private DevComponents.DotNetBar.ButtonX borrowCollapseButton;
        private DevComponents.DotNetBar.Controls.TextBoxX addBookIDTextBox;
        private System.Windows.Forms.FlowLayoutPanel borrowFlowLayout;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX clearBorrowButton;
        private DevComponents.DotNetBar.Controls.GroupPanel returnGroupBox;
        private DevComponents.DotNetBar.ButtonX returnAllButton;
        private DevComponents.DotNetBar.ButtonX returnCollapseButton;
        private System.Windows.Forms.FlowLayoutPanel returnFlowLayout;
        private DevComponents.DotNetBar.ButtonX buttonX4;
    }
}
