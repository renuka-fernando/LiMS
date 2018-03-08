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
        private class Cell : Button
        {
            public const int CELL_W = 65;
            public const int CELL_H = 35;
            public const int CELL_MARGIN = 0;

            public Cell(string txt)
                : base()
            {
                Text = txt;
                FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
                Size = new Size(CELL_W, CELL_H);
                Font = new Font("Microsoft Sans Serif", 18);
                Margin = new System.Windows.Forms.Padding(CELL_MARGIN);
            }

            public bool IsCellSelected
            {
                get;
                set;
            }

            public void Disable()
            {
                Enabled = false;
            }

            public void InvertSelection()
            {
                IsCellSelected = !IsCellSelected;
                if(IsCellSelected)
                {
                    BackColor = HolidayCalender.HolidayColour;
                }
                else
                {
                    BackColor = SystemColors.Window;
                }
            }

            internal void SelectCell()
            {
                IsCellSelected = true;
                BackColor = Color.LightCoral;
            }

            internal void DeselectCell()
            {
                IsCellSelected = false;
                BackColor = SystemColors.Window;
            }
        }
    }
}
