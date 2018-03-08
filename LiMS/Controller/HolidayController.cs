using LiMS.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Controller
{
    class HolidayController
    {
        public static void addHolidays(DateTime monthDate, List<int> days)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "DELETE FROM [Holiday] WHERE MONTH([date]) = @month";
            command.Parameters.AddWithValue("@month", monthDate.Month);
            command.ExecuteNonQuery();

            int countNew = days.Count;
            int year = monthDate.Year;
            int month = monthDate.Month;
            foreach(int day in days)
            {
                string newDate = new DateTime(year, month, day).ToString("yyyy/M/d");
                command.CommandText = "INSERT INTO [Holiday]([date]) VALUES ('" + newDate + "')";
                command.ExecuteNonQuery();
            }

            DBConnection.CloseConnection();
        }

        public static List<int> loadHolidays(DateTime monthDate)
        {
            List<int> holidayList = new List<int>();
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT [date] FROM [Holiday] WHERE MONTH([date]) = @month";
            command.Parameters.AddWithValue("@month", monthDate.Month);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int day = DateTime.Parse(reader["date"].ToString()).Day;
                holidayList.Add(day);
            }

            DBConnection.CloseConnection();
            return holidayList;
        }

        public static bool IsAHoliday(DateTime date)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT [holidayID] FROM [Holiday] WHERE [date] = @date;";
            command.Parameters.AddWithValue("@date", date);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    return true;
                }
                return false;
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }
        }
    }
}
