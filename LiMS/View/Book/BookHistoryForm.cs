using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;
using LiMS.View.Member;

namespace LiMS.View.Book
{
    public partial class BookHistoryForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BookHistoryForm()
        {
            InitializeComponent();
        }

        public string AccessNo
        {
            get { return accessNoTextBox.Text; }
            set { accessNoTextBox.Text = value;}
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable table = MemberController.GetMembers(AccessNo);
            dataGridView.DataSource = table;
        }

        private void accessNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberHistoryForm memberH = new MemberHistoryForm();
            memberH.MemberNo = dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[0].Value.ToString();
            memberH.searchButton.PerformClick();
            memberH.ShowDialog();
        }
    }
}