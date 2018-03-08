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
using LiMS.Report;

namespace LiMS.View.Book
{
    public partial class BookReportViewerForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        DataSet dataSet = new DataSet();

        public BookReportViewerForm()
        {
            InitializeComponent();
            filterSortSlidePanel.IsOpen = false;

            SQLSelectCommandModel command = new SQLSelectCommandModel();
            command.Table = "Book";
            command.Columns = "*";

            DataSet dataSet = new DataSet();
            DataTable table = SQLCommandController.SelectFrom(command, "Book");
            dataSet.Tables.Add(table);

            BookReport report = new BookReport();
            report.SetDataSource(dataSet);
            crystalReportViewer.ReportSource = report;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }
    }
}