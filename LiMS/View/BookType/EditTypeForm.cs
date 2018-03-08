using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Model;
using LiMS.Controller;

namespace LiMS.View.BookType
{
    public partial class EditTypeForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        int typeNo;

        public int TypeNo
        {
            get { return typeNo; }
            set { typeNo = value; }
        }

        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set {
                typeName = value;
                nameTextBox.Text = value;
            }
        }
        Color colour;

        public Color Colour
        {
            get { return colour; }
            set {
                colour = value;
                colorDialog.Color = value;
                colourLabel.BackColor = value;
            }
        }
        public EditTypeForm()
        {
            InitializeComponent();
        }

        private void changeColourButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                Colour = colorDialog.Color;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            TypeName = nameTextBox.Text;
            BookTypeModel bookType = new BookTypeModel()
            {
                Name = TypeName,
                Colour = Colour
            };
            BookTypeController.EditBookType(TypeNo, bookType);
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                okButton.PerformClick();
            }
        }

        private void EditTypeForm_Load(object sender, EventArgs e)
        {
            colourLabel.BackColor = Colour;
        }
    }
}