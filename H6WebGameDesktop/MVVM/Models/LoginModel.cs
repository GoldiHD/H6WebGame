using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6WebGameDesktop.MVVM.Models
{
    class LoginModel : BaseModel
    {
        private string username;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if(username != value)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }
    }
}
