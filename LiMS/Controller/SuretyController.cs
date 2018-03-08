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
    class SuretyController
    {
        public static void addSurety(SuretyModel surety)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "INSERT INTO [Surety]([name], [address], [tel]) VALUES(@Sname, @Saddress, @Stel);";
            command.Parameters.AddWithValue("@Sname", surety.Name);
            command.Parameters.AddWithValue("@Saddress", surety.Address);
            command.Parameters.AddWithValue("@Stel", surety.Tel);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static DataTable GetSureties()
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Surety];";
            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable("Surety");
            table.Load(reader);
            reader.Close();
            DBConnection.CloseConnection();
            return table;
        }
    }
}
