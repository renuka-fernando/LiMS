using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using LiMS.Controller;
using LiMS.Model;
using LiMS.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiMS.MyControl.TransactionPanel
{
    partial class TransactionTabPanel
    {
        private void bookIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchIDTextBox.WatermarkText = "Book ID";
            searchIDTextBox.Select();
        }

        private void MemberIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchIDTextBox.WatermarkText = "Member ID";
            searchIDTextBox.Select();
        }

        private void verifyNextButton_Click(object sender, EventArgs e)
        {
            transactionPageSlider.SelectedPageIndex = 1;
            verifyStep.Value = 100;
        }

        private void verifyPage_Resize(object sender, EventArgs e)
        {
            setMiddle(searchPanel, verifyPage);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string accessNo;
            string memberNo;
            //Get the member who doesn't return the book
            #region Get the member
            if(bookIDRadioButton.Checked)
            {
                accessNo = searchIDTextBox.Text;
                memberNo = TransactionController.GetMember_NotReturned(accessNo);
                if(memberNo == null)
                {
                    ValidationClass.ShowInvalidError(
                        highlighter,
                        searchIDTextBox,
                        "This Book is already available in the Library OR\nAccession Number is not valid!",
                        "Invalid Accession Number"
                    );

                    //No Execution further
                    return;
                }
            }
            else
            {
                memberNo = searchIDTextBox.Text;
                if(!MemberController.IsMemberExists(memberNo))
                {
                    ValidationClass.ShowInvalidError(
                        highlighter,
                        searchIDTextBox,
                        "Invalid Member Number",
                        "Member No"
                    );

                    //No Execution further
                    return;
                }
            }

            //Load Member
            MemberModel member = MemberController.GetMember(memberNo);

            //If the member is already opened by a tab in parent form
            SubItemsCollection openedTabs = ParentTransForm.GetOpenedTabs();//TODO : This in not good
            for(int i = 0; i < openedTabs.Count; i++)
            {
                if(openedTabs[i].Text == member.Name)
                {
                    MessageBox.Show("This Member has already opened in a Tab.");
                    return;
                }
            }

            Member = member;
            memberPanel.Visible = true;

            #endregion

            //Load Books
            #region Load Books
            List<TransactionModel> transList = TransactionController.GetTransactions(memberNo);
            int transCount = transList.Count;
            returnBooks = new ReturnBookPanel[transCount];
            returnFlowLayout.Controls.Clear();
            for(int i = 0; i < transCount; i++)
            {
                BookModel book = BookController.GetBook(transList[i].AccessNo);
                addReturnBooksToTheFlowLayout(ref returnBooks[i]);
                returnBooks[i].BookModel = book;
                returnBooks[i].Transaction = transList[i];
            }
            isAllReturned();
            #endregion

            verifyNextButton.PerformClick();
        }

        private void addReturnBooksToTheFlowLayout(ref ReturnBookPanel returnBook)
        {
            returnBook = new ReturnBookPanel();
            returnBook.Click += returnBook_Click;
            returnBook.ParentTabPanel = this;
            returnFlowLayout.Controls.Add(returnBook);
            returnBorrowFlowLayout_Resize(returnFlowLayout, null);
        }

        private void searchIDTextBox_TextChanged(object sender, EventArgs e)
        {
            highlighter.SetHighlightColor(searchIDTextBox, eHighlightColor.None);
        }

        private void searchIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                findButton.PerformClick();
            }
        }
    }
}
