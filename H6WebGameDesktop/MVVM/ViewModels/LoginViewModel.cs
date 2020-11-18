using H6WebGameDesktop.MVVM.Commands;
using H6WebGameDesktop.MVVM.Models;
using H6WebGameDesktop.MVVM.Views;
using H6WebGameDesktop.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace H6WebGameDesktop.MVVM.ViewModels
{
    class LoginViewModel
    {
        private Login _View;
        private LoginModel _Model;
        public LoginViewModel(Login view)
        {
            _View = view;
            _Model = new LoginModel();
            UseLoginCommand = new LoginCommand(this);
            UseCreateAccountCommand = new OpenCreateAccountCommand(this);
        }

        public LoginModel Model
        {
            get
            { 
                return _Model;
            }
        }

        public Login View
        {
            get
            {
                return _View;
            }
        }

        public ICommand UseLoginCommand
        {
            get; private set;
        }

        public ICommand UseCreateAccountCommand
        {
            get; private set;
        }

        public void LoginIntoAccount()
        {
            if(SingleTon.GetAccessAPI().LoginIntoProfile(_Model.Username, _View.PBPassword.Password).Result)
            {
                MainWindow.WVM.ChangeView(Pages.MainScreen);
            }
        }

        public void OpenAccountCreateView()
        {
            MainWindow.WVM.ChangeView(Pages.CreateAccount);
        }
    }
}
