using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;
using LiMS.View.Book;

namespace LiMS.View.Member
{
    public partial class MemberHistoryForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MemberHistoryForm()
        {
            InitializeComponent();
        }

        public string MemberNo
        {
            get { return memberNoTextBox.Text; }
            set { memberNoTextBox.Text = value; }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable table = BookController.GetBooks(MemberNo);
            dataGridView.DataSource = table;
        }

        private void memberNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookHistoryForm bookH = new BookHistoryForm();
            bookH.AccessNo = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
            bookH.searchButton.PerformClick();
            bookH.ShowDialog();
        }
    }
}