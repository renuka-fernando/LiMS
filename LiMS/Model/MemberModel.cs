using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    class MemberModel
    {
        string memberNo;

        public string MemberNo
        {
            get { return memberNo; }
            set { memberNo = value; }
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
        DateTime regDate;

        public DateTime RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }
        Gender gender;

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        string nic;

        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }
        DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        int suretyID;

        public int SuretyID
        {
            get { return suretyID; }
            set { suretyID = value; }
        }
    }
}
