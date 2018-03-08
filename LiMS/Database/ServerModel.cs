using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiMS.Database
{
    public class ServerModel
    {
        string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string server;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
    }
}
