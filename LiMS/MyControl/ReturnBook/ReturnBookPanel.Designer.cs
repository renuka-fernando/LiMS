namespace LiMS.MyControl.TransactionPanel
{
    partial class ReturnBookPanel
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
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.accessIDLinkLabel = new System.Windows.Forms.LinkLabel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finePanel = new System.Windows.Forms.Panel();
            this.fineButton = new DevComponents.DotNetBar.ButtonX();
            this.daysCountLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.returnPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.mustReturnDateLabel = new System.Windows.Forms.Label();
            this.undoReturnButton = new DevComponents.DotNetBar.ButtonX();
            this.returnButton = new DevComponents.DotNetBar.ButtonX();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            this.finePanel.SuspendLayout();
            this.returnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.typeLabel);
            this.detailsPanel.Controls.Add(this.accessIDLinkLabel);
            this.detailsPanel.Controls.Add(this.priceLabel);
            this.detailsPanel.Controls.Add(this.publisherLabel);
            this.detailsPanel.Controls.Add(this.authorLabel);
            this.detailsPanel.Controls.Add(this.nameLabel);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.label2);
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(602, 95);
            this.detailsPanel.TabIndex = 0;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(453, 3);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(144, 21);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "802.54";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // accessIDLinkLabel
            // 
            this.accessIDLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessIDLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessIDLinkLabel.Location = new System.Drawing.Point(2, 3);
            this.accessIDLinkLabel.Name = "accessIDLinkLabel";
            this.accessIDLinkLabel.Size = new System.Drawing.Size(442, 21);
            this.accessIDLinkLabel.TabIndex = 10;
            this.accessIDLinkLabel.TabStop = true;
            this.accessIDLinkLabel.Text = "Book ID";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(489, 70);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(108, 21);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Rs. 250.00";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // publisherLabel
            // 
            this.publisherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(89, 70);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(394, 21);
            this.publisherLabel.TabIndex = 8;
            this.publisherLabel.Text = "මල්පියලි";
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(89, 47);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(505, 21);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "මාර්ටින් වික්‍රමසිංහ";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(89, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(505, 21);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "මඩොල් දූව";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // finePanel
            // 
            this.finePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finePanel.Controls.Add(this.fineButton);
            this.finePanel.Controls.Add(this.daysCountLabel);
            this.finePanel.Controls.Add(this.label14);
            this.finePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.finePanel.Location = new System.Drawing.Point(790, 0);
            this.finePanel.Margin = new System.Windows.Forms.Padding(0);
            this.finePanel.Name = "finePanel";
            this.finePanel.Size = new System.Drawing.Size(190, 95);
            this.finePanel.TabIndex = 1;
            this.finePanel.Visible = false;
            this.finePanel.VisibleChanged += new System.EventHandler(this.finePanel_VisibleChanged);
            // 
            // fineButton
            // 
            this.fineButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.fineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fineButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.fineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineButton.Location = new System.Drawing.Point(43, 68);
            this.fineButton.Name = "fineButton";
            this.fineButton.Size = new System.Drawing.Size(142, 23);
            this.fineButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.fineButton.TabIndex = 18;
            this.fineButton.Text = "Fine Rs. 30.00";
            this.fineButton.Click += new System.EventHandler(this.fineButton_Click);
            // 
            // daysCountLabel
            // 
            this.daysCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.daysCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysCountLabel.Location = new System.Drawing.Point(91, 27);
            this.daysCountLabel.Name = "daysCountLabel";
            this.daysCountLabel.Size = new System.Drawing.Size(95, 21);
            this.daysCountLabel.TabIndex = 17;
            this.daysCountLabel.Text = "30";
            this.daysCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Days Count";
            // 
            // returnPanel
            // 
            this.returnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnPanel.Controls.Add(this.label12);
            this.returnPanel.Controls.Add(this.mustReturnDateLabel);
            this.returnPanel.Controls.Add(this.undoReturnButton);
            this.returnPanel.Controls.Add(this.returnButton);
            this.returnPanel.Controls.Add(this.label16);
            this.returnPanel.Controls.Add(this.label17);
            this.returnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.returnPanel.Location = new System.Drawing.Point(600, 0);
            this.returnPanel.Margin = new System.Windows.Forms.Padding(0);
            this.returnPanel.Name = "returnPanel";
            this.returnPanel.Size = new System.Drawing.Size(190, 95);
            this.returnPanel.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Must Return";
            // 
            // mustReturnDateLabel
            // 
            this.mustReturnDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mustReturnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mustReturnDateLabel.Location = new System.Drawing.Point(91, 27);
            this.mustReturnDateLabel.Name = "mustReturnDateLabel";
            this.mustReturnDateLabel.Size = new System.Drawing.Size(95, 21);
            this.mustReturnDateLabel.TabIndex = 17;
            this.mustReturnDateLabel.Text = "2016-09-12";
            this.mustReturnDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // undoReturnButton
            // 
            this.undoReturnButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.undoReturnButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.undoReturnButton.Location = new System.Drawing.Point(161, 3);
            this.undoReturnButton.Name = "undoReturnButton";
            this.undoReturnButton.Size = new System.Drawing.Size(21, 21);
            this.undoReturnButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.undoReturnButton.TabIndex = 1;
            this.undoReturnButton.Text = "X";
            this.undoReturnButton.Click += new System.EventHandler(this.undoReturnButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.returnButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(6, 48);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(176, 42);
            this.returnButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Return";
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(91, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "2016-10-12";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 21);
            this.label17.TabIndex = 16;
            this.label17.Text = "Returned";
            // 
            // ReturnBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.returnPanel);
            this.Controls.Add(this.finePanel);
            this.Controls.Add(this.detailsPanel);
            this.Name = "ReturnBookPanel";
            this.Size = new System.Drawing.Size(980, 95);
            this.detailsPanel.ResumeLayout(false);
            this.finePanel.ResumeLayout(false);
            this.returnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.LinkLabel accessIDLinkLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel finePanel;
        private System.Windows.Forms.Label daysCountLabel;
        private System.Windows.Forms.Label label14;
        private DevComponents.DotNetBar.ButtonX fineButton;
        private System.Windows.Forms.Panel returnPanel;
        private DevComponents.DotNetBar.ButtonX returnButton;
        private DevComponents.DotNetBar.ButtonX undoReturnButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label mustReturnDateLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;

    }
}
