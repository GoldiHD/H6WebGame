using H6WebGameDesktop.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace H6WebGameDesktop.MVVM.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Window myWindow;

        public Pages currentPage { get; set; } = Pages.Login;

        public MainWindowViewModel(Window window)
        {
            myWindow = window;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public void ChangeView(Pages page)
        {
            currentPage = page;
            OnPropertyChanged("currentPage");
        }
    }
}
