namespace LiMS.MyControl.TransactionPanel
{
    partial class BorrowBookPanel
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
            this.removeButton = new DevComponents.DotNetBar.ButtonX();
            this.typeLabel = new System.Windows.Forms.Label();
            this.bookIDLinkLabel = new System.Windows.Forms.LinkLabel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsPanel
            // 
            this.detailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsPanel.Controls.Add(this.removeButton);
            this.detailsPanel.Controls.Add(this.typeLabel);
            this.detailsPanel.Controls.Add(this.bookIDLinkLabel);
            this.detailsPanel.Controls.Add(this.priceLabel);
            this.detailsPanel.Controls.Add(this.publisherLabel);
            this.detailsPanel.Controls.Add(this.authorLabel);
            this.detailsPanel.Controls.Add(this.nameLabel);
            this.detailsPanel.Controls.Add(this.label4);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.label2);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(980, 95);
            this.detailsPanel.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(885, 68);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 23);
            this.removeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(831, 3);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(144, 21);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "16545";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bookIDLinkLabel
            // 
            this.bookIDLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookIDLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDLinkLabel.Location = new System.Drawing.Point(2, 3);
            this.bookIDLinkLabel.Name = "bookIDLinkLabel";
            this.bookIDLinkLabel.Size = new System.Drawing.Size(820, 21);
            this.bookIDLinkLabel.TabIndex = 10;
            this.bookIDLinkLabel.TabStop = true;
            this.bookIDLinkLabel.Text = "Book ID";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(867, 47);
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
            this.publisherLabel.Size = new System.Drawing.Size(772, 21);
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
            this.authorLabel.Size = new System.Drawing.Size(883, 21);
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
            this.nameLabel.Size = new System.Drawing.Size(883, 21);
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
            // BorrowBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.detailsPanel);
            this.Name = "BorrowBookPanel";
            this.Size = new System.Drawing.Size(980, 95);
            this.detailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.LinkLabel bookIDLinkLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX removeButton;

    }
}
