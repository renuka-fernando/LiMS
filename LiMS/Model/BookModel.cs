using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    public class BookModel
    {
        string accessNo;

        public string AccessNo
        {
            get { return accessNo; }
            set { accessNo = value; }
        }
        Decimal typeNo;

        public Decimal TypeNo
        {
            get { return typeNo; }
            set { typeNo = value; }
        }
        DateTime regDate;

        public DateTime RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }
        string auther;

        public string Auther
        {
            get { return auther; }
            set { auther = value; }
        }
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        int pubYear;

        public int PubYear
        {
            get { return pubYear; }
            set { pubYear = value; }
        }
        int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        Decimal price;

        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        string source;

        public string Source
        {
            get { return source; }
            set { source = value; }
        }
        string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
    }
}
