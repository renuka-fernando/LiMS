using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiMS.MyControl.HolidayCalender
{
    partial class HolidayCalender
    {
        class DayNameLabel : Label
        {
            public DayNameLabel(string txt)
                : base()
            {
                Text = txt;
                Font = new Font("Microsoft Sans Sarif", 14);
                AutoSize = false;
                Size = new Size(Cell.CELL_W, 20);
                TextAlign = ContentAlignment.MiddleCenter;
                Margin = new Padding(Cell.CELL_MARGIN);
            }
        }
    }
}
