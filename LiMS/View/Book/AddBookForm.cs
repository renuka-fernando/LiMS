using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using LiMS.View.Import;
using DevComponents.DotNetBar.Validator;
using LiMS.Controller;
using LiMS.Validation;
using LiMS.Model;
using System.Data.SqlClient;
using LiMS.View.BookType;

namespace LiMS.View.Book
{
    public partial class AddBookForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Control[,] defaultCheckBoxes;
        public AddBookForm()
        {
            InitializeComponent();

            setCheckBoxes();
            initDefault();
        }

        private void initDefault()
        {
            List<Control> controls = new List<Control>() {
                titleTextBox,
                pagesIntInput,
                priceDoubleInput, remarksTextBox
            };

            if(!typeCheckBox.Checked) controls.Add(typeDoubleInput);
            if(!autherCheckBox.Checked) controls.Add(autherTextBox);
            if(!publisherCheckBox.Checked) controls.Add(publisherTextBox);
            if(!pubYearCheckBox.Checked) controls.Add(pubYearIntInput);
            if(!sourceCheckBox.Checked) controls.Add(sourceTextBox);

            ValidationClass.setControlsTextEmpty(controls);

            //Registered Date set to Today
            regDatePicker.Value = DateTime.Today;
            typeLabel.BackColor = Color.White;

            //Accesiion No set to Next
            accTextBox.Text = (BookController.lastAccessionNo() + 1).ToString();
            accTextBox.Select();
            accTextBox.SelectAll();
        }

        #region Set Default Values
        private void setCheckBoxes()
        {
            defaultCheckBoxes = new Control[,] {
                {typeCheckBox, typeDoubleInput},
                {regDateCheckBox, regDatePicker},
                {autherCheckBox, autherTextBox},
                {publisherCheckBox, publisherTextBox},
                {pubYearCheckBox, pubYearIntInput},
                {sourceCheckBox, sourceTextBox}
            };

            int rowCount = defaultCheckBoxes.Length / 2;
            for(int i = 0; i < rowCount; i++)
            {
                ((CheckBoxX)defaultCheckBoxes[i, 0]).CheckedChanged += defaultCheckBox_CheckedChanged;
            }
        }

        /// <summary>
        /// Set default or not by checking checkboxes in defualtCheckBoxes array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int rowCount = defaultCheckBoxes.Length / 2;
            CheckBoxX checkBox = (CheckBoxX)sender;
            for(int i = 0; i < rowCount; i++)
            {
                if(checkBox == defaultCheckBoxes[i, 0])
                {
                    defaultCheckBoxes[i, 1].Enabled = !checkBox.Checked;
                    break;
                }
            }
        }
        #endregion

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            BookModel book = new BookModel() {
                AccessNo = accTextBox.Text,
                TypeNo = (Decimal)typeDoubleInput.Value,
                RegDate = regDatePicker.Value,
                Auther = autherTextBox.Text,
                Title = titleTextBox.Text,
                Publisher = publisherTextBox.Text,
                PubYear = pubYearIntInput.Value,
                Pages = pagesIntInput.Value,
                Price = (Decimal)priceDoubleInput.Value,
                Source = sourceTextBox.Text,
                Remarks = remarksTextBox.Text
            };

            try
            {
                BookController.addBook(book);
                initDefault();
                MessageBox.Show("Book is added successfully..", "Add Book",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validate()
        {
            Control[] controls = new Control[]{
                accTextBox, typeDoubleInput, autherTextBox,
                publisherTextBox, pubYearIntInput
            };
            string[] captions = new string[] {
                "Accession Number", "Type Number", "Auther of the Book",
                "Publisher of the Book", "Published Year"
            };

            //Accession No already exists.
            if(BookController.IsBookExists(accTextBox.Text))
            {
                ValidationClass.ShowInvalidError(highlighter, accTextBox, "The Accession No is already exists!", "Accession No");
                accTextBox.SelectAll();
                return false;
            }

            //Test for Required Fields
            bool valid = ValidationClass.ValidateEmptyText(highlighter, controls, captions);
            if(!valid) return false;

            return true;
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            highlighter.SetHighlightColor((Control)sender, eHighlightColor.None);
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            new BookTypeForm().ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?",
                "Add Book", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
            );

            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            //else do nothing.
        }

        private void typeDoubleInput_Leave(object sender, EventArgs e)
        {
            BookTypeModel type = BookTypeController.GetBookType(
                ((int)typeDoubleInput.Value) / 100 * 100);
            typeLabel.BackColor = type.Colour;
        }

    }
}