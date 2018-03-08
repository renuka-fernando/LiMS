using LiMS.Database;
using LiMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Controller
{
    class SQLCommandController
    {
        public static DataTable SelectFrom(SQLSelectCommandModel commnadModel, string tableName)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = commnadModel.CommandText;
            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable(tableName);
            table.Load(reader);
            reader.Close();
            DBConnection.CloseConnection();
            return table;
        }

        public static void InsertInto(SQLInsertCommandModel insert)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "INSET INTO " + insert.Query;
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }
    }
}
