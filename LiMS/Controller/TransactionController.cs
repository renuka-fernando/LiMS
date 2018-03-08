using LiMS.Database;
using LiMS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Controller
{
    public class TransactionController
    {
        public static string GetMember_NotReturned(string accessNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT [memberNo] FROM [Transaction] " +
                "WHERE [accessNo] = @accessNo AND [returnDate] IS NULL;";
            command.Parameters.AddWithValue("@accessNo", accessNo);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    return reader[0].ToString();
                }
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }

            return null;
        }

        public static List<TransactionModel> GetTransactions(string memberNo)
        {
            List<TransactionModel> bookList = new List<TransactionModel>();

            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Transaction] " +
                "WHERE [memberNo] = @memberNo AND [returnDate] IS NULL;";
            command.Parameters.AddWithValue("@memberNo", memberNo);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    TransactionModel trans = new TransactionModel() {
                        TransId = reader.GetInt32(0),
                        MemberNo = reader.GetString(1),
                        AccessNo = reader.GetString(2),
                        LendDate = reader.GetDateTime(3),
                    };
                    if(!reader[4].ToString().Equals(""))
                        trans.ReturnDate = reader.GetDateTime(4);
                    else
                        trans.ReturnDate = null;

                    bookList.Add(trans);
                }
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }

            return bookList;
        }

        public static void UpdateTransaction(int transId, TransactionModel trans)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "UPDATE [Transaction] SET memberNo = @memberNo, accessNo = @accessNo," +
                "lendDate = @lendDate, returnDate = @returnDate;";
            command.Parameters.AddWithValue("@memberNo", trans.MemberNo);
            command.Parameters.AddWithValue("@accessNo", trans.AccessNo);
            command.Parameters.AddWithValue("@lendDate", trans.LendDate);
            command.Parameters.AddWithValue("@returnDate", trans.ReturnDate);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static void SetReturnDate(int transId, DateTime returnDate)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "UPDATE [Transaction] SET returnDate = @returnDate;";
            command.Parameters.AddWithValue("@returnDate", returnDate);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static void addTransaction(TransactionModel trans)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "INSERT INTO [Transaction]([memberNo], [accessNo], [lendDate], [returnDate])" +
                " VALUES (@memberNo, @accessNo, @lendDate, NULL);";
            command.Parameters.AddWithValue("@memberNo", trans.MemberNo);
            command.Parameters.AddWithValue("@accessNo", trans.AccessNo);
            command.Parameters.AddWithValue("@lendDate", trans.LendDate);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static int GetBooksCount(int type, DateTime startDate)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT COUNT([memberNo]) FROM [Transaction] WHERE [accessNo] IN (" +
                " SELECT [accessNo] FROM [Book] WHERE [typeNo] >= @type AND [typeNo] < @type2);";
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@type2", type + 100);
            SqlDataReader reader = command.ExecuteReader();
            DBConnection.CloseConnection();

            if(reader.Read())
            {
                return reader.GetInt32(0);
            }
            return 0;
        }
    }
}
