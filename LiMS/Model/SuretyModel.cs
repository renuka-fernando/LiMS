using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    class SuretyModel
    {
        int suretyID;

        public int SuretyID
        {
            get { return suretyID; }
            set { suretyID = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
    }
}
