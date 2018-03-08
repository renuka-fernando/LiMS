namespace LiMS.View.Member
{
    partial class AddMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemberForm));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dateCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.suretyTelMaskedTexBox = new System.Windows.Forms.MaskedTextBox();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.suretyAddressTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.suretyNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.telMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genderComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.maleItem = new DevComponents.Editors.ComboItem();
            this.femalItem = new DevComponents.Editors.ComboItem();
            this.nicMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobDatePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.addressTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.nameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.memberNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tableModeButton = new DevComponents.DotNetBar.ButtonX();
            this.importButton = new DevComponents.DotNetBar.ButtonX();
            this.addButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.regDatePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobDatePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDatePicker)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dateCheckBox);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.tableModeButton);
            this.panelEx1.Controls.Add(this.importButton);
            this.panelEx1.Controls.Add(this.addButton);
            this.panelEx1.Controls.Add(this.cancelButton);
            this.panelEx1.Controls.Add(this.regDatePicker);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 77);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(879, 381);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dateCheckBox
            // 
            // 
            // 
            // 
            this.dateCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCheckBox.ForeColor = System.Drawing.Color.Black;
            this.dateCheckBox.Location = new System.Drawing.Point(465, 293);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(113, 29);
            this.dateCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateCheckBox.TabIndex = 2;
            this.dateCheckBox.TabStop = false;
            this.dateCheckBox.Text = "Reg &Date*";
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.suretyTelMaskedTexBox);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.suretyAddressTextBox);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.suretyNameTextBox);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(453, 79);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(421, 168);
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
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Surety";
            // 
            // suretyTelMaskedTexBox
            // 
            this.suretyTelMaskedTexBox.BackColor = System.Drawing.Color.White;
            this.suretyTelMaskedTexBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suretyTelMaskedTexBox.ForeColor = System.Drawing.Color.Black;
            this.suretyTelMaskedTexBox.Location = new System.Drawing.Point(128, 106);
            this.suretyTelMaskedTexBox.Mask = "000-00 000 00";
            this.suretyTelMaskedTexBox.Name = "suretyTelMaskedTexBox";
            this.suretyTelMaskedTexBox.Size = new System.Drawing.Size(277, 29);
            this.suretyTelMaskedTexBox.TabIndex = 5;
            this.suretyTelMaskedTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(27, 106);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(95, 23);
            this.labelX11.TabIndex = 4;
            this.labelX11.Text = "Tel";
            // 
            // suretyAddressTextBox
            // 
            this.suretyAddressTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.suretyAddressTextBox.Border.Class = "TextBoxBorder";
            this.suretyAddressTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.suretyAddressTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.suretyAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suretyAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.suretyAddressTextBox.Location = new System.Drawing.Point(128, 37);
            this.suretyAddressTextBox.Multiline = true;
            this.suretyAddressTextBox.Name = "suretyAddressTextBox";
            this.suretyAddressTextBox.PreventEnterBeep = true;
            this.suretyAddressTextBox.Size = new System.Drawing.Size(277, 63);
            this.suretyAddressTextBox.TabIndex = 3;
            this.suretyAddressTextBox.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(27, 38);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(95, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Address*";
            // 
            // suretyNameTextBox
            // 
            this.suretyNameTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.suretyNameTextBox.Border.Class = "TextBoxBorder";
            this.suretyNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.suretyNameTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.suretyNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suretyNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.suretyNameTextBox.Location = new System.Drawing.Point(128, 2);
            this.suretyNameTextBox.Name = "suretyNameTextBox";
            this.suretyNameTextBox.PreventEnterBeep = true;
            this.suretyNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.suretyNameTextBox.TabIndex = 1;
            this.suretyNameTextBox.TextChanged += new System.EventHandler(this.control_TextChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(27, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Surety*";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.telMaskedTextBox);
            this.groupPanel1.Controls.Add(this.genderComboBox);
            this.groupPanel1.Controls.Add(this.nicMaskedTextBox);
            this.groupPanel1.Controls.Add(this.dobDatePicker);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.addressTextBox);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.nameTextBox);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.memberNoTextBox);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(25, 44);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(422, 325);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Member";
            // 
            // telMaskedTextBox
            // 
            this.telMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.telMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.telMaskedTextBox.Location = new System.Drawing.Point(128, 248);
            this.telMaskedTextBox.Mask = "000-00 000 00";
            this.telMaskedTextBox.Name = "telMaskedTextBox";
            this.telMaskedTextBox.Size = new System.Drawing.Size(277, 29);
            this.telMaskedTextBox.TabIndex = 13;
            this.telMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DisplayMember = "Text";
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 23;
            this.genderComboBox.Items.AddRange(new object[] {
            this.maleItem,
            this.femalItem});
            this.genderComboBox.Location = new System.Drawing.Point(128, 141);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(277, 29);
            this.genderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.genderComboBox.TabIndex = 7;
            // 
            // maleItem
            // 
            this.maleItem.Text = "Male";
            // 
            // femalItem
            // 
            this.femalItem.Text = "Female";
            // 
            // nicMaskedTextBox
            // 
            this.nicMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.nicMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicMaskedTextBox.ForeColor = System.Drawing.Color.Black;
            this.nicMaskedTextBox.Location = new System.Drawing.Point(128, 176);
            this.nicMaskedTextBox.Mask = "000000000V";
            this.nicMaskedTextBox.Name = "nicMaskedTextBox";
            this.nicMaskedTextBox.Size = new System.Drawing.Size(277, 29);
            this.nicMaskedTextBox.TabIndex = 9;
            this.nicMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dobDatePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dobDatePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dobDatePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dobDatePicker.ButtonDropDown.Visible = true;
            this.dobDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDatePicker.ForeColor = System.Drawing.Color.Black;
            this.dobDatePicker.IsPopupCalendarOpen = false;
            this.dobDatePicker.Location = new System.Drawing.Point(128, 212);
            // 
            // 
            // 
            this.dobDatePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dobDatePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dobDatePicker.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dobDatePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dobDatePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dobDatePicker.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.dobDatePicker.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dobDatePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dobDatePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dobDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dobDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dobDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dobDatePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dobDatePicker.MonthCalendar.TodayButtonVisible = true;
            this.dobDatePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(277, 29);
            this.dobDatePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dobDatePicker.TabIndex = 11;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(27, 248);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(95, 23);
            this.labelX10.TabIndex = 12;
            this.labelX10.Text = "Tel";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(27, 213);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(95, 23);
            this.labelX9.TabIndex = 10;
            this.labelX9.Text = "DOB*";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(27, 178);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(95, 23);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "NIC";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(27, 143);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(95, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Gender*";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.addressTextBox.Border.Class = "TextBoxBorder";
            this.addressTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addressTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.Location = new System.Drawing.Point(128, 72);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PreventEnterBeep = true;
            this.addressTextBox.Size = new System.Drawing.Size(277, 63);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.TextChanged += new System.EventHandler(this.control_TextChanged);
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
            this.labelX4.Location = new System.Drawing.Point(27, 73);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 23);
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "Address*";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nameTextBox.Border.Class = "TextBoxBorder";
            this.nameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nameTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(128, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PreventEnterBeep = true;
            this.nameTextBox.Size = new System.Drawing.Size(277, 29);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.control_TextChanged);
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
            this.labelX3.Location = new System.Drawing.Point(27, 38);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(95, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Name*";
            // 
            // memberNoTextBox
            // 
            this.memberNoTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.memberNoTextBox.Border.Class = "TextBoxBorder";
            this.memberNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.memberNoTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.memberNoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNoTextBox.ForeColor = System.Drawing.Color.Black;
            this.memberNoTextBox.Location = new System.Drawing.Point(128, 2);
            this.memberNoTextBox.Name = "memberNoTextBox";
            this.memberNoTextBox.PreventEnterBeep = true;
            this.memberNoTextBox.Size = new System.Drawing.Size(125, 29);
            this.memberNoTextBox.TabIndex = 1;
            this.memberNoTextBox.TextChanged += new System.EventHandler(this.control_TextChanged);
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
            this.labelX2.Location = new System.Drawing.Point(27, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Member No*";
            // 
            // tableModeButton
            // 
            this.tableModeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.tableModeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.tableModeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableModeButton.Enabled = false;
            this.tableModeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableModeButton.Location = new System.Drawing.Point(684, 6);
            this.tableModeButton.Name = "tableModeButton";
            this.tableModeButton.Size = new System.Drawing.Size(92, 50);
            this.tableModeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tableModeButton.Symbol = "";
            this.tableModeButton.TabIndex = 6;
            this.tableModeButton.Text = "&Table";
            this.tableModeButton.Click += new System.EventHandler(this.tableModeButton_Click);
            // 
            // importButton
            // 
            this.importButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.importButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(782, 6);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(92, 50);
            this.importButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.importButton.Symbol = "";
            this.importButton.TabIndex = 7;
            this.importButton.Text = "&Import";
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // addButton
            // 
            this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.addButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(674, 355);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 23);
            this.addButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(777, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // regDatePicker
            // 
            // 
            // 
            // 
            this.regDatePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.regDatePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.regDatePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.regDatePicker.ButtonDropDown.Visible = true;
            this.regDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDatePicker.ForeColor = System.Drawing.Color.Black;
            this.regDatePicker.IsPopupCalendarOpen = false;
            this.regDatePicker.Location = new System.Drawing.Point(584, 293);
            // 
            // 
            // 
            this.regDatePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.regDatePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.regDatePicker.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.regDatePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.regDatePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.regDatePicker.MonthCalendar.DisplayMonth = new System.DateTime(2016, 7, 1, 0, 0, 0, 0);
            this.regDatePicker.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.regDatePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.regDatePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.regDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.regDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.regDatePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.regDatePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.regDatePicker.MonthCalendar.TodayButtonVisible = true;
            this.regDatePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.regDatePicker.Name = "regDatePicker";
            this.regDatePicker.Size = new System.Drawing.Size(277, 29);
            this.regDatePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.regDatePicker.TabIndex = 3;
            this.regDatePicker.Value = new System.DateTime(2016, 7, 6, 17, 59, 39, 0);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(879, 77);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 45);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Add Members";
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiMS - Add Member";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMemberForm_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobDatePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDatePicker)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput regDatePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX suretyAddressTextBox;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX suretyNameTextBox;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX addressTextBox;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX nameTextBox;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX memberNoTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX importButton;
        private DevComponents.DotNetBar.ButtonX addButton;
        private DevComponents.DotNetBar.ButtonX tableModeButton;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX dateCheckBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dobDatePicker;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.MaskedTextBox nicMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telMaskedTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx genderComboBox;
        private DevComponents.Editors.ComboItem maleItem;
        private DevComponents.Editors.ComboItem femalItem;
        private System.Windows.Forms.MaskedTextBox suretyTelMaskedTexBox;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;

    }
}