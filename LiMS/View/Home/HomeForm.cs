using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.View.Holiday;
using LiMS.View.Transaction;
using LiMS.View.Member;
using LiMS.View.Book;
using LiMS.View.BookType;
using LiMS.MyControl.HolidayCalender;
using LiMS.Controller;

namespace LiMS.View.Home
{
    public partial class HomeForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();

            holidayCalender.SetMonth(DateTime.Today);
        }

        private void holidayButton_Click(object sender, EventArgs e)
        {
            new HolidayForm().ShowDialog(this);
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
            transactionForm.Focus();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            HolidayCalender.HolidayColour = Color.LightCoral;
            holidayCalender.SelectedDays = HolidayController.loadHolidays(DateTime.Today);
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            new AddMemberForm().Show();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            new AddBookForm().Show();
        }

        private void memberReportButton_Click(object sender, EventArgs e)
        {
            new MemberReportViewerForm().Show();
        }

        private void bookTypeButton_Click(object sender, EventArgs e)
        {
            new BookTypeForm().Show();
        }

        private void bookReportButton_Click(object sender, EventArgs e)
        {
            new BookReportViewerForm().Show();
        }

        private void memberHistoryButton_Click(object sender, EventArgs e)
        {
            new MemberHistoryForm().Show();
        }

        private void bookHistoryButton_Click(object sender, EventArgs e)
        {
            new BookHistoryForm().Show();
        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            new TransactionSequenceForm().Show();
        }
    }
}