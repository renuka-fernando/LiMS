using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LiMS.MyControl.HolidayCalender
{
    public partial class HolidayCalender : UserControl
    {
        private Cell[] cells;
        private int prevMonthVisibleCount;
        private int thisMonthCount;
        private int nextMonthVisibleCount;

        private int selectedCellIndex;
        private bool shiftKeyDown = false;

        public HolidayCalender()
        {
            InitializeComponent();
            reInitializeComponent(); //Changes to InitializeComponent();
            initDayNames(); //Initialize Names of Days of Week

            if(HolidayColour == null) HolidayColour = Color.LightCoral;
        }

        private void reInitializeComponent()
        {
            this.cellsFlowLayout.Size = new System.Drawing.Size(Cell.CELL_W * 7 + Cell.CELL_MARGIN * 7, Cell.CELL_H * 6 + Cell.CELL_MARGIN * 6);
            this.monthLabel.Size = new System.Drawing.Size(cellsFlowLayout.Size.Width, 23);
            this.dayNameFlowLayout.Size = new System.Drawing.Size(cellsFlowLayout.Size.Width, 20);
            this.Size = new System.Drawing.Size(cellsFlowLayout.Size.Width + 10, cellsFlowLayout.Size.Height + cellsFlowLayout.Location.Y + 5);
        }

        private void initDayNames()
        {
            DayNameLabel[] dayNames = new DayNameLabel[7];
            string[] names = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            for(int i = 0; i < 7; i++)
            {
                dayNames[i] = new DayNameLabel(names[i]);
                dayNameFlowLayout.Controls.Add(dayNames[i]);
            }
        }

        /// <summary>
        /// Show dates in the calender
        /// </summary>
        /// <param name="prevCount">No of days in prev month</param>
        /// <param name="thisCount">No of days in this month</param>
        /// <param name="startDay">DayOfWeek in 1st day of the month</param>
        private void initCells(int prevCount, int thisCount, int startDay)
        {
            cells = new Cell[42];
            cellsFlowLayout.Controls.Clear();

            //If the first day is Monday then show 7 days of prev month
            if(startDay == 0) startDay = 7;

            //Calculating days to display
            prevMonthVisibleCount = startDay;
            thisMonthCount = thisCount;
            nextMonthVisibleCount = 42 - (startDay + thisCount);

            //Init prev month cells
            int prevMonthStart = prevCount - startDay + 1;
            for(int i = 0; i < prevMonthVisibleCount; i++)
            {
                cells[i] = new Cell((prevMonthStart + i).ToString());
                cells[i].Disable();
            }

            //init this month cells
            for(int i = 0; i < thisMonthCount; i++)
            {
                cells[prevMonthVisibleCount + i] = new Cell((i + 1).ToString());
                cells[prevMonthVisibleCount + i].Enabled = true;
            }

            //init next month cells
            int nextMonthStart = startDay + thisCount;
            for(int i = 0; i < nextMonthVisibleCount; i++)
            {
                cells[nextMonthStart + i] = new Cell((i + 1).ToString());
                cells[nextMonthStart + i].Disable();
            }

            //Set styles for all cells
            for(int i = 0; i < 42; i++)
            {
                cells[i].MouseDown += OneMonthCalender_MouseDown;
                cells[i].KeyDown += OneMonthCalender_KeyDown;
                cells[i].KeyUp += OneMonthCalender_KeyUp;
                cellsFlowLayout.Controls.Add(cells[i]);
            }
        }

        /// <summary>
        /// Find days count, dayofweek of 1st day in a specific month
        /// </summary>
        /// <param name="month"></param>
        private void OneMonthCalender_KeyDown(object sender, KeyEventArgs e)
        {
            shiftKeyDown = e.Shift;
        }

        void OneMonthCalender_KeyUp(object sender, KeyEventArgs e)
        {
            shiftKeyDown = e.Shift;
        }

        void OneMonthCalender_MouseDown(object sender, MouseEventArgs e)
        {
            Cell cell = (Cell)sender;
            int lastSelectedCellIndex = selectedCellIndex;
            selectedCellIndex = prevMonthVisibleCount + int.Parse(cell.Text) - 1;

            if(shiftKeyDown)
            {
                for(int i = lastSelectedCellIndex; i <= selectedCellIndex; i++)
                {
                    cells[i].SelectCell();
                }
            } else
            {
                cell.InvertSelection();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        public void SetMonth(DateTime month)
        {
            if(month.Day != 1) month = month.AddDays(1 - month.Day);

            monthLabel.Text = month.ToString("MMMM yyyy");
            DateTime nextMonth = month.AddMonths(1);
            DateTime prevMonth = month.AddMonths(-1);

            int daysCount = (nextMonth - month).Days;
            int daysCountPrev = (month - prevMonth).Days;

            int startDay = (int)month.DayOfWeek - 1;
            if(startDay == -1) startDay = 6;

            initCells(daysCountPrev, daysCount, startDay);
        }

        public void ClearSelection()
        {
            for(int i = 0; i < thisMonthCount; i++)
            {
                cells[prevMonthVisibleCount + i].DeselectCell();
            }
        }

        public List<int> SelectedDays
        {
            get
            {
                List<int> days = new List<int>();
                for(int i = 0; i < thisMonthCount; i++)
                {
                    if(cells[prevMonthVisibleCount + i].IsCellSelected) days.Add(i + 1);
                }
                return days;
            }
            set
            {
                ClearSelection();
                foreach(int day in value)
                {
                    if(day < 1 || day > thisMonthCount)
                        throw new ArgumentOutOfRangeException(String.Format("Day out of range [0 - {0}]", thisMonthCount));

                    cells[prevMonthVisibleCount + day - 1].SelectCell();
                }
            }
        }

        public static Color HolidayColour
        {
            get;
            set;
        }
    }
}
