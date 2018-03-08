using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LiMS.MyControl.HolidayCalender;
using LiMS.Controller;

namespace LiMS.View.Holiday
{
    public partial class HolidayForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        DateTime displayMonth;
        public HolidayForm()
        {
            InitializeComponent();
            reInitComponent();
            initHolidayCalender();
        }

        private void reInitComponent()
        {
            //this.AcceptButton = okButton;
        }

        private void initHolidayCalender()
        {
            displayMonth = DateTime.Today.AddMonths(1);
            holidayCalender.SetMonth(displayMonth);
            HolidayCalender.HolidayColour = holidayColourLabel.BackColor;
        }

        private void HolidayForm_Load(object sender, EventArgs e)
        {
            holidayColourLabel.BackColor = HolidayCalender.HolidayColour;
            holidayCalender.SelectedDays = HolidayController.loadHolidays(displayMonth);
        }

        private void HolidayForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter: //TODO: Not working
                    okButton.PerformClick();
                    break;
                case Keys.Escape:
                    cancelButton.PerformClick();
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            HolidayController.addHolidays(displayMonth, holidayCalender.SelectedDays);
        }
    }
}