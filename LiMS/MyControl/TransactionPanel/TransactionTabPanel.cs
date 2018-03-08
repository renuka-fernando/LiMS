using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;
using LiMS.Validation;
using LiMS.Model;
using DevComponents.DotNetBar.Validator;
using LiMS.View.Transaction;

namespace LiMS.MyControl.TransactionPanel
{
    public partial class TransactionTabPanel : UserControl
    {
        public TransactionForm ParentTransForm;
        StepItem[] steps; //This array is initilized in "void setProgressColours()"

        public TransactionTabPanel()
        {
            InitializeComponent();
            setProgressColours();
            setReturnDate();
        }

        private void setReturnDate()
        {
            _returnDate = DateTime.Today.AddDays(SettingsModel.MaxDaysCount);

            #region Check the calculated date is a holiday and set the date to next
            bool isAHoliday = HolidayController.IsAHoliday(ReturnDate);
            while(isAHoliday)
            {
                ReturnDate.AddDays(1);
                isAHoliday = HolidayController.IsAHoliday(ReturnDate);
            }
            #endregion

            returnDatePicker.Value = ReturnDate;
        }

        #region Set Step Progress Colours
        /// <summary>
        /// Set Progress colour according to StyleManager's Base Colour
        /// StepItems should be declared here
        /// </summary>
        private void setProgressColours()
        {
            //
            steps = new StepItem[] { verifyStep, returnStep, borrowStep };
            Color baseColour = StyleManager.MetroColorGeneratorParameters.BaseColor;
            Color[] progressColours = new Color[]{ Color.FromArgb(baseColour.ToArgb() + 0x66000000),  baseColour};

            foreach(StepItem step in steps)
            {
                step.ProgressColors = progressColours;
            }
        }
        #endregion

        private void LendingTabPanel_Enter(object sender, EventArgs e)
        {
            searchIDTextBox.Select();
        }

        private void searchIDTextBox_Enter(object sender, EventArgs e)
        {
            searchIDTextBox.SelectAll();
        }

        private MemberModel Member
        {
            get {return _member;}
            set
            {
                _member = value;

                memberNoLabel.Text = value.MemberNo;
                nameLabel.Text = value.Name;
                ParentTransForm.SetSelectedTabDisplayText(value.Name);
            }
            
        }

        private void returnBorrowFlowLayout_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanel flowLayout = (FlowLayoutPanel)sender;
            if(flowLayout.Controls.Count == 0)
            {
                flowLayout.Controls.Add(new NothingLabel());
            }
        }

        private class NothingLabel : Label
        {
            public NothingLabel()
            {
                Text = "Nothing...";
                Font = new Font("Microsoft Sans Serif", 20);
                ForeColor = Color.LightGray;
                AutoSize = true;
            }
        }

        /// <summary>
        /// Resize controls in FlowLayoutPanel due to not working Anchors
        /// </summary>
        private void returnBorrowFlowLayout_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayout = (FlowLayoutPanel)sender;

            ///calculate value to reduce
            int reduceSize;
            if(flowLayout.VerticalScroll.Visible) reduceSize = 24;
            else reduceSize = 8;

            //Do for all controls
            foreach(Control item in flowLayout.Controls)
            {
                item.Width = flowLayout.Width - reduceSize;
            }
        }

        /// <summary>
        /// Set the Step Progess to val (0 based index)
        /// </summary>
        /// <param name="val"></param>
        private void setProgressStep(int val)
        {
            int i;
            for(i = 0; i <= val; i++)
            {
                steps[i].Value = 100;
            }

            for( ; i < steps.Length; i++)
            {
                steps[i].Value = 0;
            }
        }

        private void transactionPageSlider_SelectedPageChanged(object sender, EventArgs e)
        {
            setProgressStep(transactionPageSlider.SelectedPageIndex);
            highlighter.SetHighlightColor(searchIDTextBox, eHighlightColor.None);
        }

        /// <summary>
        /// Set a control in a middle of a control
        /// </summary>
        /// <param name="middle">To be in middle</param>
        /// <param name="baseControl">Parent control</param>
        private void setMiddle(Control middle, Control baseControl)
        {
            middle.Location = new Point(
                (baseControl.Width - middle.Width)/2,
                (baseControl.Height - middle.Height)/2
            );
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            #region Check for maximum
            if(borrowFlowLayout.Controls.Count > SettingsModel.MaxBookCount)
            {
                MessageBox.Show("Can't lend more books", "Maximum Reached");
                return;
            }
            #endregion

            string accessNo = addBookNoTextBox.Text;

            #region Check whether exists
            bool isExists = BookController.IsBookExists(accessNo);
            if(!isExists)
            {
                ValidationClass.ShowInvalidError(
                    highlighter,
                    addBookNoTextBox,
                    "There is not a Book with this Accession Number.",
                    "Invalid Accession No"
                );
                return; //End Execution
            }
            #endregion

            #region Is Book Available (No member has borrowed)
            bool isAvailable = TransactionController.GetMember_NotReturned(accessNo) == null;

            if(!isAvailable)
            {
                ValidationClass.ShowInvalidError(
                    highlighter,
                    addBookNoTextBox,
                    "The Book has been borrowed by other Member.\n" +
                        "The Book is not available now.",
                    "Not Available"
                );
                return; //End Execution
            }
            #endregion

            #region Check for Already Exists
            foreach(Control control in borrowFlowLayout.Controls)
            {
                BorrowBookPanel bookPanel = (BorrowBookPanel)control;
                if(bookPanel.Book.AccessNo == accessNo)
                {
                    ValidationClass.ShowInvalidError(
                        highlighter,
                        addBookNoTextBox,
                        "The Book has been already added.",
                        "Duplicating Book"
                    );
                    return;
                }
            }
            #endregion

            BookModel book = BookController.GetBook(accessNo);
            BorrowBookPanel borrowBookPanel = new BorrowBookPanel();
            borrowBookPanel.Book = book;
            borrowBookPanel.ParentTabPanel = this;
            borrowFlowLayout.Controls.Add(borrowBookPanel);
            returnBorrowFlowLayout_Resize(borrowFlowLayout, null);

            addBookNoTextBox.Text = "";
            addBookNoTextBox.Select();
        }

        public void RemoveBookFromList(BorrowBookPanel bookPanel)
        {
            borrowFlowLayout.Controls.Remove(bookPanel);
        }

        private int maxBooksCount = 2;
        private ReturnBookPanel[] returnBooks;
        private  MemberModel _member;

        private void addBookNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addBookButton.PerformClick();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            foreach(Control control in borrowFlowLayout.Controls)
            {
                BorrowBookPanel bookPanel = (BorrowBookPanel)control;
                addTransaction(Member, bookPanel.Book);
            }
            ParentTransForm.closeThisTab();
        }

        private void addTransaction(MemberModel member, BookModel book)
        {
            TransactionModel trans = new TransactionModel()
            {
                MemberNo = member.MemberNo,
                AccessNo = book.AccessNo,
                LendDate = DateTime.Today,
                ReturnDate = null
            };
            TransactionController.addTransaction(trans);
        }

        DateTime _returnDate;

        public DateTime ReturnDate
        {
            get { return _returnDate; }
        }

        private void returnAllButton_Click(object sender, EventArgs e)
        {
            int count = returnFlowLayout.Controls.Count;
            for(int i = 0; i < count; i++)
            {
                ReturnBookPanel book = (ReturnBookPanel)returnFlowLayout.Controls[i];
                book.IsReturend = true;
            }
            returnNextButton.Enabled = true;
        }
    }
}
