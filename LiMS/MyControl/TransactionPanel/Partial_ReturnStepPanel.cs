using LiMS.Controller;
using LiMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiMS.MyControl.TransactionPanel
{
    partial class TransactionTabPanel
    {
        private void returnNextButton_Click(object sender, EventArgs e)
        {
            if(returnFlowLayout.Controls.Count != 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure?\nMember has returned all books.",
                    "Return Books", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
                );

                if(result == DialogResult.No) return; //If(No) end execution
                //else continue
            }

            updateAllBooksToReturnTrue();

            transactionPageSlider.SelectedPageIndex = 2;
            returnStep.Value = 100;
        }

        private void updateAllBooksToReturnTrue()
        {
            int bookCount = returnFlowLayout.Controls.Count;
            for(int i = 0; i < bookCount; i++)
            {
                ReturnBookPanel book = (ReturnBookPanel)returnFlowLayout.Controls[i];
                TransactionModel trans = book.Transaction;
                trans.ReturnDate = DateTime.Today;

                TransactionController.SetReturnDate(trans.TransId, DateTime.Today);
            }
        }

        public bool isAllReturned()
        {
            foreach(Control bookControl in returnFlowLayout.Controls)
            {
                ReturnBookPanel book = (ReturnBookPanel)bookControl;
                if(!book.IsReturend)
                {
                    returnNextButton.Enabled = false;
                    return false;
                }
            }

            returnNextButton.Enabled = true;

            return true;
        }

        private void returnPrevButton_Click(object sender, EventArgs e)
        {
            transactionPageSlider.SelectedPageIndex = 0;
            returnStep.Value = 0;
        }

        void returnBook_Click(object sender, EventArgs e)
        {
            ReturnBookPanel returnBook = (ReturnBookPanel)sender;
            returnBook.IsReturend = !returnBook.IsReturend;
            MessageBox.Show("Clicked");
        }
    }
}
