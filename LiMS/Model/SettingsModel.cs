using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    public class SettingsModel
    {
        //Static Variables since only one object is needed...
        static int maxBookCount = 2;

        public static int MaxBookCount
        {
            get { return SettingsModel.maxBookCount; }
            set { SettingsModel.maxBookCount = value; }
        }
        static int maxDaysCount = 14;

        public static int MaxDaysCount
        {
            get { return SettingsModel.maxDaysCount; }
            set { SettingsModel.maxDaysCount = value; }
        }
    }
}
