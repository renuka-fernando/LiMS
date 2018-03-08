using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;
using LiMS.Model;
using System.Data.SqlClient;
using DevComponents.DotNetBar.Validator;
using LiMS.Validation;
using LiMS.View.Import;

namespace LiMS.View.Member
{
    public partial class AddMemberForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public AddMemberForm()
        {
            InitializeComponent();

            initDefault();
        }

        private void initDefault()
        {
            List<Control> controls = new List<Control>() {
                nameTextBox, addressTextBox, nicMaskedTextBox,
                dobDatePicker, telMaskedTextBox, suretyNameTextBox,
                suretyAddressTextBox, suretyTelMaskedTexBox
            };
            ValidationClass.setControlsTextEmpty(controls);

            //Set Memebr No to next value
            memberNoTextBox.Text = (MemberController.lastMemberNo() + 1).ToString();
            
            //Set gender to Male
            genderComboBox.SelectedIndex = 0;
            //Set Registered Date to Today
            regDatePicker.Value = DateTime.Today;
            memberNoTextBox.Select();
        }

        private void tableModeButton_Click(object sender, EventArgs e)
        {
            new AddMemberTableForm().Show();
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            regDatePicker.Enabled = !dateCheckBox.Checked;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!validate())
            {
                return;
            }

            MemberModel member = new MemberModel()
            {
                MemberNo = memberNoTextBox.Text,
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                RegDate = regDatePicker.Value,
                Gender = GenderClass.getGenderType(genderComboBox.SelectedIndex),
                Nic = nicMaskedTextBox.Text,
                Dob = dobDatePicker.Value,
                Tel = telMaskedTextBox.Text,
            };
            SuretyModel surety = new SuretyModel()
            {
                Name = suretyNameTextBox.Text,
                Address = suretyAddressTextBox.Text,
                Tel = suretyTelMaskedTexBox.Text
            };

            try
            {
                MemberController.addMemberSurety(member, surety);
                MessageBox.Show("Member is successfully entered.", "Add Member",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                initDefault();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validate()
        {
            Control[] controls = new Control[] {
                memberNoTextBox, nameTextBox, addressTextBox,
                dobDatePicker, suretyNameTextBox, suretyAddressTextBox
            };
            string[] captions = new string[] {
                "Member Number", "Name of the Member", "Address of the Member",
                "Date of Birth of the Member", "Name of the Surety", "Address of the Surety"
            };

            //Member No already exists.
            if(MemberController.IsMemberExists(memberNoTextBox.Text))
            {
                inValid(memberNoTextBox, "The Member No is already exists!", "Member No");
                memberNoTextBox.SelectAll();
                return false;
            }

            //Test for Required Fields
            bool valid = ValidationClass.ValidateEmptyText(highlighter, controls, captions);
            if(!valid) return false;

            return true;
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            valid((Control)sender);
        }

        private void valid(Control control)
        {
            highlighter.SetHighlightColor(control, eHighlightColor.None);
        }

        private void inValid(Control control, string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            highlighter.SetHighlightColor(control, eHighlightColor.Red);
            control.Select();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportForm import = new ImportForm();
            import.SetMemberImport();
            import.ShowDialog();
        }

        private void AddMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?",
                "Add Member", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
            );

            if(dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            //else do nothing.
        }
    }
}