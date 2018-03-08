using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Model
{
    class SQLInsertCommandModel
    {
        string table;

        public string Table
        {
            get { return table; }
            set { table = value; }
        }

        string[] columns;

        public string[] Columns
        {
            set { columns = value; }
        }
        string[] data;

        public string[] Data
        {
            set { data = value; }
        }

        public string Query
        {
            get
            {
                if(isReset == null) setResetBools();

                string query = table + "(" +columns[0];
                for(int i = 1; i < columns.Length; i++)
                {
                    query += ", " + columns[i];
                }

                query += ") VALUES(" + resetData(0);
                for(int i = 1; i < columns.Length; i++)
                {
                    query += ", " + resetData(i);
                }
                query += ")";

                return query;
            }
        }

        private void setResetBools()
        {
            isReset = new bool[columns.Length];
            for(int i = 0; i < columns.Length; i++)
            {
                try
                {
                    isReset[i] = columns[i].Substring(0, 5).ToLower().Equals("(int)");
                }
                catch(IndexOutOfRangeException)
                {

                }
            }

            for(int i = 0; i < columns.Length; i++)
            {
                if(isReset[i])
                {
                    try
                    {
                        columns[i] = columns[i].Substring(5);
                    }
                    catch(IndexOutOfRangeException)
                    {

                    }
                }
            }
        }

        private string resetData(int i)
        {
            if(isReset[i]) return data[i];
            else return "'" + data[i] + "'";
        }

        private bool[] isReset;
    }
}
