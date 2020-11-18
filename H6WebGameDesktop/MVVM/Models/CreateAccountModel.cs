using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6WebGameDesktop.MVVM.Models
{
    class CreateAccountModel : BaseModel
    {
        private string username;
        private string password;
        private bool showtext;
        public bool ShowText
        {
            get
            {
                return showtext;
            }
            set
            {
                if (showtext != value)
                {
                    showtext = value;
                    OnPropertyChanged("FailedToCreateAccount");
                }
            }
        }

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
                    OnPropertyChanged("CreateAccountUsername");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(password != value)
                {
                    password = value;
                    OnPropertyChanged("CreateAccountPassword");
                }
            }
        }
    }
}
