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
    class BookTypeController
    {
        public static void AddBookType(BookTypeModel bookType)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "INSERT INTO [BookType] VALUES(@typeNo, @name, @colour;";
            command.Parameters.AddWithValue("@typeNo", bookType.TypeNo);
            command.Parameters.AddWithValue("@name", bookType.Name);
            command.Parameters.AddWithValue("@colour", bookType.ColourInt);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static DataTable GetBookType()
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [BookType];";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            
            reader.Close();
            DBConnection.CloseConnection();

            return table;
        }

        public static void EditBookType(int typeNo, BookTypeModel bookType)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "UPDATE [BookType] SET [name] = @name, [colour] = @colour " +
                "WHERE [typeNo] = @typeNo;";
            command.Parameters.AddWithValue("@typeNo", typeNo);
            command.Parameters.AddWithValue("@name", bookType.Name);
            command.Parameters.AddWithValue("@colour", bookType.ColourInt);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static BookTypeModel GetBookType(int typeNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [BookType] WHERE [typeNo] = @typeNo;";
            command.Parameters.AddWithValue("@typeNo", (typeNo / 100) * 100);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    BookTypeModel bookType = new BookTypeModel()
                    {
                        TypeNo = reader.GetInt32(0),
                        Name = reader[1].ToString(),
                        ColourInt = reader.GetInt32(2)
                    };

                    return bookType;
                }
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }

            return null;
        }
    }
}
