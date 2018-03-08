using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    public class TransactionModel
    {
        int transId;

        public int TransId
        {
            get { return transId; }
            set { transId = value; }
        }
        string memberNo;

        public string MemberNo
        {
            get { return memberNo; }
            set { memberNo = value; }
        }
        string accessNo;

        public string AccessNo
        {
            get { return accessNo; }
            set { accessNo = value; }
        }
        DateTime lendDate;

        public DateTime LendDate
        {
            get { return lendDate; }
            set { lendDate = value; }
        }
        DateTime? returnDate;

        public DateTime? ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
    }
}
