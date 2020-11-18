using H6WebGameDesktop.MVVM.Views;
using H6WebGameDesktop.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6WebGameDesktop.MVVM.ValueConverters
{
    public class PageValueConverter: BaseValueConverter<PageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((Pages)value)
            {
                case Pages.Login:
                    return new Login();

                case Pages.CreateAccount:
                    return new CreateAccount();

                case Pages.MainScreen:
                    return new MainPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
