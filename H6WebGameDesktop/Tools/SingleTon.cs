using H6WebGameDesktop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6WebGameDesktop.Tools
{
    class SingleTon
    {
        public const string APIIP = "https://localhost:44375";
        private static AccessAPI AccessAPIInstance;
        private static User UserInstance;
        public static AccessAPI GetAccessAPI()
        {
            if(AccessAPIInstance == null)
            {
                AccessAPIInstance = new AccessAPI(); 
            }
            return AccessAPIInstance;
        }

        public static User GetCurrentUser()
        {
            if(UserInstance == null)
            {
                UserInstance = new User();
            }
            return UserInstance;
        }
    }
}
