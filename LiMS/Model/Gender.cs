using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    public enum Gender
    {
        Male,
        Female
    }

    public class GenderClass
    {
        public static Gender getGenderType(int id)
        {
            if(id == 0) return Gender.Male;
            else return Gender.Female;
        }
    }
}
