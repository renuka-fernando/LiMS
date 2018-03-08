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
    class MemberController
    {
        public static void addMemberSurety(MemberModel member, SuretyModel surety)
        {
            SuretyController.addSurety(surety);

            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            #region Get Surety No
            command.CommandText = "SELECT MAX(suretyID) FROM Surety;";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                surety.SuretyID = reader.GetInt32(0);
            }
            reader.Close();
            #endregion

            DBConnection.CloseConnection();

            addMember(member, surety.SuretyID);
        }

        public static void addMember(MemberModel member, int? suretyID)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText += "INSERT INTO [Member]"
                + "VALUES(@memberNo, @name, @address, @regDate, @gender, @nic, @dob, @tel, @suretyID);";
            command.Parameters.AddWithValue("@memberNo", member.MemberNo);
            command.Parameters.AddWithValue("@name", member.Name);
            command.Parameters.AddWithValue("@address", member.Address);
            command.Parameters.AddWithValue("@regDate", member.RegDate);
            command.Parameters.AddWithValue("@gender", member.Gender == Gender.Male);
            command.Parameters.AddWithValue("@nic", member.Nic);
            command.Parameters.AddWithValue("@dob", member.Dob);
            command.Parameters.AddWithValue("@tel", member.Tel);
            command.Parameters.AddWithValue("@suretyID", suretyID);
            command.ExecuteNonQuery();

            DBConnection.CloseConnection();
        }

        public static bool IsMemberExists(string memberId)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT [memberNo] FROM [Member] WHERE [memberNo] = @memberNo;";
            command.Parameters.AddWithValue("@memberNo", memberId);
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

        public static int lastMemberNo()
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT MAX([memberNo]) FROM [Member];";
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

        public static MemberModel GetMember(string memberNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Member] WHERE [memberNo] = @memberNo;";
            command.Parameters.AddWithValue("@memberNo", memberNo);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if(reader.Read())
                {
                    MemberModel member = new MemberModel()
                    {
                        MemberNo = reader[0].ToString(),
                        Name = reader[1].ToString(),
                        Address = reader[2].ToString(),
                        RegDate = reader.GetDateTime(3),
                        //Gender = reader[4].ToString(),
                        Nic = reader[5].ToString(),
                        //Dob = reader.GetDateTime(6),
                        Tel = reader[7].ToString(),
                        SuretyID = reader.GetInt32(8) //Required Field
                    };
                    member.Gender = reader.GetBoolean(4) ? Gender.Male : Gender.Female;
                    
                    //If DOB is null
                    member.Dob = reader[6].ToString().Equals("") ?
                        Constant.Constants.NULL_DATE : reader.GetDateTime(6);

                    return member;
                }
            }
            finally
            {
                reader.Close();
                DBConnection.CloseConnection();
            }
            return null;
        }

        public static DataTable GetMembers(string accessNo)
        {
            DBConnection.OpenConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = DBConnection.ConnectionString;

            command.CommandText = "SELECT * FROM [Member] WHERE [memberNo] IN (" +
                "SELECT [memberNo] FROM [Transaction] WHERE [accessNo] = @accessNo);";
            command.Parameters.AddWithValue("@accessNo", accessNo);
            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }
    }
}
