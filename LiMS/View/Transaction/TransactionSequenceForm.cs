using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.Controller;

namespace LiMS.View.Transaction
{
    public partial class TransactionSequenceForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public TransactionSequenceForm()
        {
            InitializeComponent();
            drawChart();
        }

        private void drawChart()
        {
            chart.Series.Clear();
            chart.Series.Add("bookSeries");

            //For 10types
            for(int i = 0; i < 10; i++)
            {
                chart.Series[0].Points.Add(TransactionController.GetBooksCount(i * 100, DateTime.Today));
            }
        }
    }
}