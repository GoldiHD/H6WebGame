using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity
{
    public class User
    {
        public string userID;
        public string username;
        public string password;//hashed ofc
        public string token;
    }
}
