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
    class BookController
    {
        public static bool IsBookExists(string accessNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT [accessNo] FROM [Book] WHERE [accessNo] = @accessNo;";
            command.Parameters.AddWithValue("@accessNo", accessNo);
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

        public static void addBook(BookModel book)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "INSERT INTO [Book] VALUES(@accessNo, @typeNo, @regDate, " +
                "@auther, @title, @publisher, @pubYear, @pages, @price, @source, @remarks);";
            command.Parameters.AddWithValue("@accessNo", book.AccessNo);
            command.Parameters.AddWithValue("@typeNo", book.TypeNo);
            command.Parameters.AddWithValue("@regDate", book.RegDate);
            command.Parameters.AddWithValue("@auther", book.Auther);
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@publisher", book.Publisher);
            command.Parameters.AddWithValue("@pubYear", book.PubYear);
            command.Parameters.AddWithValue("@pages", book.Pages);
            command.Parameters.AddWithValue("@price", book.Price);
            command.Parameters.AddWithValue("@source", book.Source);
            command.Parameters.AddWithValue("@remarks", book.Remarks);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static int lastAccessionNo()
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT MAX([accessNo]) FROM [Book];";
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    return int.Parse(reader[0].ToString());
                }
                return 0;
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }
        }

        public static BookModel GetBook(string accessNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Book] WHERE [accessNo] = @accessNo;";
            command.Parameters.AddWithValue("@accessNo", accessNo);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    BookModel book = new BookModel()
                    {
                        AccessNo = reader.GetString(0),
                        TypeNo = reader.GetDecimal(1),
                        RegDate = reader.GetDateTime(2),
                        Auther = reader.GetString(3),
                        Title = reader.GetString(4),
                        Publisher = reader.GetString(5),
                        PubYear = reader.GetInt32(6),
                        Pages = reader.GetInt32(7),
                        Price = reader.GetDecimal(8),
                        Source = reader.GetString(9),
                        Remarks = reader.GetString(10)
                    };

                    return book;
                }
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }

            return null;
        }

        public static DataTable GetBooks(string memberNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Book] WHERE [accessNo] IN (" +
                "SELECT [accessNo] FROM [Transaction] WHERE [memberNo] = @memberNo);";
            command.Parameters.AddWithValue("@memberNo", memberNo);
            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable("Book");
            table.Load(reader);
            return table;
        }
    }
}
