using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    public class BookTypeModel
    {
        int typeNo;

        public int TypeNo
        {
            get { return typeNo; }
            set { typeNo = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        int colour;

        public int ColourInt
        {
            get { return colour; }
            set { colour = value; }
        }

        public Color Colour
        {
            get { return Color.FromArgb(colour); }
            set { colour = value.ToArgb(); }
        }
    }
}
