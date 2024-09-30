using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Services
{
    interface IApplicationService
    {
        void ChangeTheme(string theme);
    }

    public class ApplicationService : IApplicationService
    {
        public void ChangeTheme(string theme)
        {
            //Application.Current!.Resources.MergedDictionaries.ElementAt(0).Source = new Uri(string.Format("/Styles/Colors{0}.xaml", theme), UriKind.Relative);
        }
    }
}
