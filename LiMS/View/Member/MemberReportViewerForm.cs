using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Report;
using LiMS.Controller;
using LiMS.Model;

namespace LiMS.View.Member
{
    public partial class MemberReportViewerForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        DataSet dataSet = new DataSet();
        MemberReport report = new MemberReport();
        public MemberReportViewerForm()
        {
            InitializeComponent();

            setDefaultValues();
        }

        private void setDefaultValues()
        {
            filterSortSlidePanel.IsOpen = false;
            feeRangeTypeComboBox.SelectedIndex = 1;
            memberIDComboBox.SelectedIndex = 0;
            nameComboBox.SelectedIndex = 0;
            ageComboBox.SelectedIndex = 0;
            suretyNameComboBox.SelectedIndex = 0;
        }

        private void MemberReportViewerForm_Load(object sender, EventArgs e)
        {
            applyButton.PerformClick();
        }

        private void filterSlidePanel_Leave(object sender, EventArgs e)
        {
            filterSortSlidePanel.IsOpen = false;
        }

        private void filterSlidePanel_IsOpenChanged(object sender, EventArgs e)
        {
            if(filterSortSlidePanel.IsOpen)
            {
                applyButton.Select();
            }
        }

        private void customRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customPanel.Enabled = customRadioButton.Checked;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            dataSet.Tables.Clear();
            SQLSelectCommandModel command = new SQLSelectCommandModel();
            command.Columns = "*";
            command.Table = "Member";

            setFilterDataCommnadText(ref command);
            setSortDataCommandText(ref command);

            dataSet.Tables.Add(SQLCommandController.SelectFrom(command, "Member"));
            dataSet.Tables.Add(SuretyController.GetSureties());

            report.SetDataSource(dataSet);
            crystalReportViewer.ReportSource = report;

            filterSortSlidePanel.IsOpen = false;
        }

        private void setFilterDataCommnadText(ref SQLSelectCommandModel command)
        {
            //Don't Modify if allRadioButton is true
            if(allRadioButton.Checked) return; //End Execution

            //Then Custom is truex.Checked)
            //TOP
            if(topRowsCheckBox.Checked)
            {
                command.Top = "TOP " + topRowsIntInput.Value;
            }

            //WHERE
            if(notReturnedCheckBox.Checked)
            {
                if(!command.WhereText.Equals("")) command.WhereText += " AND ";
                command.WhereText = "[memberNo] IN (" +
                        "SELECT [memberNo] FROM [Transaction] WHERE [returnDate] IS NULL" +
                    ")";
            }

            if(notPaidCheckBox.Checked)
            {
                //TODO : Filter Not Paid
            }
            if(feeRangeCheckBox.Checked)
            {
                //TODO : Filter Not Paid
            }
        }

        private void setSortDataCommandText(ref SQLSelectCommandModel command)
        {
            //ORDER BY
            if(memberIDRadioButton.Checked)
            {
                if(!command.OrderByText.Equals("")) command.OrderByText += ", ";
                command.OrderByText = " [memberNo] " + ((memberIDComboBox.SelectedIndex == 0) ? "ASC" : "DESC");
            }
            if(nameRadioButton.Checked)
            {
                if(!command.OrderByText.Equals("")) command.OrderByText += ", ";
                command.OrderByText = " [name] " + ((nameComboBox.SelectedIndex == 0) ? "ASC" : "DESC");
            }
            if(ageRadioButton.Checked)
            {
                if(!command.OrderByText.Equals("")) command.OrderByText += ", ";
                command.OrderByText = " [dob] " + ((ageComboBox.SelectedIndex == 0) ? "DESC" : "ASC");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterSortSlidePanel.IsOpen = true;
        }
        private void topRowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            topPanel.Enabled = topRowsCheckBox.Checked;
        }

        private void feeRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            feeRangePanel.Enabled = feeRangeCheckBox.Checked;
        }

        private void memberIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            memberIDComboBox.Enabled = memberIDRadioButton.Checked;
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameComboBox.Enabled = nameRadioButton.Checked;
        }

        private void ageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ageComboBox.Enabled = ageRadioButton.Checked;
        }

        private void suretyNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameComboBox.Enabled = nameRadioButton.Checked;
        }
    }
}