using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;

namespace LiMS.View.BookType
{
    public partial class BookTypeForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public BookTypeForm()
        {
            InitializeComponent();
        }
        private void setColourButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            try
            {
                row = dataGridView.SelectedRows[0];
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a Row");
                return;
            }

            EditTypeForm editType = new EditTypeForm()
            {
                TypeNo = int.Parse(row.Cells[0].Value.ToString()),
                TypeName = row.Cells[1].Value.ToString(),
                Colour = row.Cells[2].Style.BackColor
            };
            DialogResult dialogResult = editType.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                row.Cells[1].Value = editType.TypeName;
                row.Cells[2].Style.BackColor = editType.Colour;
                dataGridView.ClearSelection();
            }
            
        }

        private void BookTypeForm_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void loadTable()
        {
            DataTable table = BookTypeController.GetBookType();
            if(table == null) return;

            foreach(DataRow row in table.Rows)
            {
                int? colour = row[2] as int?;

                dataGridView.Rows.Add(row[0], row[1], "");

                //Set colour
                int count = dataGridView.Rows.Count;
                if(colour != null)
                    dataGridView.Rows[count - 1].Cells[2].Style.BackColor = Color.FromArgb((int)colour);
                dataGridView.Refresh();
            }
        }
    }
}