using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    class SQLSelectCommandModel
    {
        public string CommandText
        {
            get
            {
                return string.Format(
                    "SELECT {0} {1} FROM {2} {3} {4};",
                    Top, Columns, Table, WhereText, OrderByText
                );
            }
        }
        string top;

        public string Top
        {
            get { return top; }
            set { top = value; }
        }
        string table;

        public string Table
        {
            get { return table; }
            set { table = value; }
        }
        string columns;

        public string Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        bool where;
        string whereText;

        public string WhereText
        {
            get {
                return where ? "WHERE " + whereText : "";
            }
            set {
                where = !value.Equals("");
                whereText = value;
            }
        }
        bool orderBy;
        string orderByText;

        public string OrderByText
        {
            get {
                return orderBy ? "ORDER BY " + orderByText : "";
            }
            set {
                orderBy = !value.Equals("");
                orderByText = value;
            }
        }
    }
}
