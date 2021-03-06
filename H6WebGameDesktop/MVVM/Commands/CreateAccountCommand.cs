﻿using H6WebGameDesktop.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace H6WebGameDesktop.MVVM.Commands
{
    class CreateAccountCommand : ICommand
    {
        private CreateAccountViewModel viewModel;

        public CreateAccountCommand(CreateAccountViewModel vm)
        {
            viewModel = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.TryCreateAccount();
        }
    }
}
