using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGamePhoneApp.Entity
{
    public class User
    {
        public string userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }

        public void SetData(User OtherUser)
        {
            userID = OtherUser.userID;
            username = OtherUser.username;
            password = "";
            token = OtherUser.token;
        }
    }
}
