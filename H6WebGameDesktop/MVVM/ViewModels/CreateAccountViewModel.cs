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
    class CreateAccountViewModel
    {
        private CreateAccount _View;
        private CreateAccountModel _Model;
        
        public CreateAccountViewModel(CreateAccount view)
        {
            _View = view;
            _Model = new CreateAccountModel();
            _Model.ShowText = false;
            UseCreateAccountCommand = new CreateAccountCommand(this);
            UseReturnToLoginCACommand = new ReturnToLoginFromACCommand(this);
        }

        public CreateAccountModel Model
        {
            get
            {
                return _Model;
            }
        }

        public ICommand UseCreateAccountCommand
        {
            get; private set;
        }

        public ICommand UseReturnToLoginCACommand
        {
            get; private set;
        }

        public void TryCreateAccount()
        {
            if (_Model.Username != "" && _Model.Username != null && _Model.Password != "" && _Model.Password != null)
            {
                if (SingleTon.GetAccessAPI().CreateAccount(_Model.Username, _Model.Password).Result)
                {
                    _Model.ShowText = true;
                }
            }
        }

        public void ReturnToLoginScreen()
        {
            MainWindow.WVM.ChangeView(Pages.Login);
        }
    }
}
