namespace LiMS.View.BookType
{
    partial class BookTypeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTypeForm));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.colorCombControl1 = new DevComponents.DotNetBar.ColorPickers.ColorCombControl();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.autherTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pagesIntInput = new DevComponents.Editors.IntegerInput();
            this.setColourButton = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.typeNoColumn = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesIntInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.colorCombControl1);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.autherTextBox);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.pagesIntInput);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Enabled = false;
            this.panelEx1.Location = new System.Drawing.Point(0, 327);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 10);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // colorCombControl1
            // 
            this.colorCombControl1.ForeColor = System.Drawing.Color.Black;
            this.colorCombControl1.Location = new System.Drawing.Point(90, 59);
            this.colorCombControl1.Name = "colorCombControl1";
            this.colorCombControl1.Size = new System.Drawing.Size(92, 29);
            this.colorCombControl1.TabIndex = 2;
            this.colorCombControl1.Text = "colorCombControl1";
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
            this.labelX3.Location = new System.Drawing.Point(5, 59);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 29);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Colour";
            // 
            // autherTextBox
            // 
            this.autherTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.autherTextBox.Border.Class = "TextBoxBorder";
            this.autherTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autherTextBox.DisabledBackColor = System.Drawing.Color.White;
            this.autherTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autherTextBox.ForeColor = System.Drawing.Color.Black;
            this.autherTextBox.Location = new System.Drawing.Point(311, 24);
            this.autherTextBox.Name = "autherTextBox";
            this.autherTextBox.PreventEnterBeep = true;
            this.autherTextBox.Size = new System.Drawing.Size(226, 29);
            this.autherTextBox.TabIndex = 5;
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
            this.labelX1.Location = new System.Drawing.Point(226, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 29);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Name";
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
            this.labelX2.Location = new System.Drawing.Point(5, 24);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 29);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Type No";
            // 
            // pagesIntInput
            // 
            this.pagesIntInput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pagesIntInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.pagesIntInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pagesIntInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.pagesIntInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pagesIntInput.ForeColor = System.Drawing.Color.Black;
            this.pagesIntInput.Increment = 100;
            this.pagesIntInput.Location = new System.Drawing.Point(90, 24);
            this.pagesIntInput.MaxValue = 99999;
            this.pagesIntInput.MinValue = 1;
            this.pagesIntInput.Name = "pagesIntInput";
            this.pagesIntInput.Size = new System.Drawing.Size(92, 29);
            this.pagesIntInput.TabIndex = 2;
            this.pagesIntInput.Value = 100;
            // 
            // setColourButton
            // 
            this.setColourButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.setColourButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.setColourButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setColourButton.Location = new System.Drawing.Point(547, 311);
            this.setColourButton.Name = "setColourButton";
            this.setColourButton.Size = new System.Drawing.Size(97, 23);
            this.setColourButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.setColourButton.TabIndex = 4;
            this.setColourButton.Text = "Edit";
            this.setColourButton.Click += new System.EventHandler(this.setColourButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNoColumn,
            this.nameColumn,
            this.colourColumn});
            this.dataGridView.Location = new System.Drawing.Point(0, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(644, 296);
            this.dataGridView.TabIndex = 5;
            // 
            // typeNoColumn
            // 
            // 
            // 
            // 
            this.typeNoColumn.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.typeNoColumn.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.typeNoColumn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeNoColumn.BackgroundStyle.TextColor = System.Drawing.Color.Black;
            this.typeNoColumn.HeaderText = "Type No";
            this.typeNoColumn.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.typeNoColumn.Name = "typeNoColumn";
            this.typeNoColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Type";
            this.nameColumn.MinimumWidth = 100;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 400;
            // 
            // colourColumn
            // 
            this.colourColumn.HeaderText = "Colour";
            this.colourColumn.Name = "colourColumn";
            this.colourColumn.ReadOnly = true;
            // 
            // BookTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.setColourButton);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookTypeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Type";
            this.Load += new System.EventHandler(this.BookTypeForm_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagesIntInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.Editors.IntegerInput pagesIntInput;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX autherTextBox;
        private DevComponents.DotNetBar.ColorPickers.ColorCombControl colorCombControl1;
        private DevComponents.DotNetBar.ButtonX setColourButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn typeNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourColumn;
    }
}