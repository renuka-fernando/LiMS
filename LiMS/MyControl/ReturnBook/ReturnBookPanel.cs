using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiMS.View;
using LiMS.Model;
using LiMS.Controller;

namespace LiMS.MyControl.TransactionPanel
{
    public partial class ReturnBookPanel : UserControl
    {
        private static Color NOT_RETURNED_COLOUR = Color.FromArgb(255, 223 , 242, 248);//0xedf8fb
        private static Color RETURNED_COLOUR = Color.FromArgb(255, 108, 193, 215);

        private bool _isReturn = false;
        private bool hasFine = false;
        private int lateDayCount = 0;

        public TransactionTabPanel ParentTabPanel { get; set; }

        public ReturnBookPanel()
        {
            InitializeComponent();
            detailsPanel.Width = this.Width - returnPanel.Width;
            IsReturend = false;
        }

        public bool IsReturend
        {
            get { return _isReturn; }
            set
            {
                _isReturn = value;
                if(value) doIsReturnTrue();
                else doIsReturnFalse();
            }
        }

        public BookModel BookModel
        {
            get { return _bookModel; }
            set{
                _bookModel = value;
                accessIDLinkLabel.Text = value.AccessNo;
                nameLabel.Text = value.Title;
                authorLabel.Text = value.Auther;
                publisherLabel.Text = value.Publisher;
                typeLabel.Text = value.TypeNo.ToString();
                BookType = BookTypeController.GetBookType((int)value.TypeNo);
                priceLabel.Text = "Rs. " + value.Price.ToString();
            }
        }

        public BookTypeModel BookType
        {
            get { return _bookType; }
            set
            {
                _bookType = value;
                typeLabel.BackColor = value.Colour;
            }
        }

        public TransactionModel Transaction
        {
            get { return _transaction; }
            set
            {
                DateTime mustReturnDate;
                mustReturnDate = ParentTabPanel.ReturnDate;
                mustReturnDateLabel.Text = mustReturnDate.ToString("yyyy/M/d");

                //If have fines
                hasFine = DateTime.Today > mustReturnDate;
                lateDayCount = (DateTime.Today - mustReturnDate).Days;
                _transaction = value;
            }
        }

        private void doIsReturnTrue()
        {
            this.BackColor = RETURNED_COLOUR;
            returnButton.Visible = false;
            undoReturnButton.Visible = true;
        }

        private void doIsReturnFalse()
        {
            this.BackColor = NOT_RETURNED_COLOUR;
            returnButton.Visible = true;
            undoReturnButton.Visible = false;
        }

        private void finePanel_VisibleChanged(object sender, EventArgs e)
        {
            if(finePanel.Visible)
            {
                detailsPanel.Width = this.Width - returnPanel.Width - finePanel.Width;
            }
            else
            {
                detailsPanel.Width = this.Width - returnPanel.Width;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            finePanel.Visible = hasFine;
            IsReturend = true;

            ParentTabPanel.isAllReturned();
        }

        private void undoReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to undo the Returning Book?", "Undo Operation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(result == DialogResult.Yes)
            {
                finePanel.Visible = false;
                IsReturend = false;

                ParentTabPanel.isAllReturned();
            }
            //else Do nothing
        }

        private void fineButton_Click(object sender, EventArgs e)
        {
            FineFeeReceiptForm fineFeeReceipt = new FineFeeReceiptForm();
            DialogResult result = fineFeeReceipt.ShowDialog();
            if(result == DialogResult.Yes)
            {

            }
            else if(result == DialogResult.No)
            {

            }
        }

        private TransactionModel _transaction;
        private Model.BookModel _bookModel;
        private BookTypeModel _bookType;
    }
}