using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Database
{
    class DBConnection
    {
        private static SqlConnection connectionString = new SqlConnection(
            @"User id=Renuka-PC\Renuka" +
            "password=;" +
            @"server=RENUKA-PC\SQLEXPRESS;" +
            "Trusted_Connection=yes;" +
            "database=LiMS_DB;" +
            "Connection timeout=30;"
        );

        public static SqlConnection ConnectionString
        {
            get { return DBConnection.connectionString; }
        }

        public static void OpenConnection()
        {
            if(ConnectionString.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    ConnectionString.Open();
                }
                catch(SqlException)
                {
                    ServerForm serverForm = new ServerForm();
                    serverForm.ShowDialog();
                    ServerModel server = serverForm.Server;
                    connectionString = new SqlConnection(
                        string.Format("User id={0} password={1}; server={2};" +
                            "Trusted_Connection=yes;" +
                            "database=LiMS_DB;" +
                            "Connection timeout=30;",
                            server.UserID, server.Password, server.Server
                        )
                    );
                    OpenConnection();
                }
            }
        }

        public static void CloseConnection()
        {
            if(ConnectionString.State != System.Data.ConnectionState.Closed)
            {
                ConnectionString.Close();
            }
        }
    }
}
