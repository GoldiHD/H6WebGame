using H6WebGamePhoneApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGamePhoneApp.Tools
{
    public class SingleTon
    {
        private static AccessAPI AccessAPIInstance;
        private static User UserIstance;
        public const string APIIP = "https://localhost:44375";

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
            if(UserIstance == null)
            {
                UserIstance = new User();
            }
            return UserIstance;
        }
    }
}
