using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiMS.Model;
using LiMS.Controller;

namespace LiMS.MyControl.TransactionPanel
{
    public partial class BorrowBookPanel : UserControl
    {
        private BookModel _book;
        private BookTypeModel _bookType;
        public TransactionTabPanel ParentTabPanel { get; set; }

        public BorrowBookPanel()
        {
            InitializeComponent();
        }

        public BookModel Book
        {
            get
            {
                return _book;
            }
            set
            {
                _book = value;
                bookIDLinkLabel.Text = value.AccessNo;
                nameLabel.Text = value.Title;
                authorLabel.Text = value.Auther;
                publisherLabel.Text = value.Publisher;
                typeLabel.Text = value.TypeNo.ToString();
                BookType = BookTypeController.GetBookType((int)value.TypeNo);
                priceLabel.Text = value.Price.ToString();
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Do you want to remove this book\nfrom borrow list?",
                "Remove Book", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
            );

            if(dialogResult == DialogResult.Yes)
            {
                ParentTabPanel.RemoveBookFromList(this);
            }
            //Else do nothing
        }
    }
}
