using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.FileInputOutput;

namespace LiMS.View.Import
{
    public partial class ImportForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        string filePath = "";

        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            importingPanel.Visible = false;
            importProgress.IsRunning = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                filePathTextBox.Text = filePath;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if(filePath.Equals(""))
            {
                MessageBox.Show("Please browse a file first.", "Import",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("The process can't be undo after importing...\n" +
                "Do you really want to import?", "Import", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
            );

            if(result == DialogResult.Yes)
            {
                importingPanel.Visible = true;
                string table = "";
                if(memberRadioButton.Checked) table = "Member";
                else if(bookRadioButton.Checked) table = "Book";

                int[] sucessFail = ImportClass.ImportMembers(table, filePath);
                importProgress.IsRunning = false;
                MessageBox.Show("Import Sucess With\n\n" +
                    "Sucess\t: " + sucessFail[0].ToString() + "\n" +
                    "Fail\t: " + sucessFail[1].ToString());
            }
        }

        public void SetBookImport()
        {
            bookRadioButton.Checked = true;
            memberRadioButton.Checked = false;
        }

        public void SetMemberImport()
        {
            bookRadioButton.Checked = false;
            memberRadioButton.Checked = true;
        }
    }
}