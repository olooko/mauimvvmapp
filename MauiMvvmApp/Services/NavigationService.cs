using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Services
{
    public interface INavigationService
    {
        public void SetContent(ContentView? contentView);
    }

    public class NavigationService : INavigationService
    {
        public void SetContent(ContentView? contentView)
        {
            MainPage? mainPage = App.Current!.MainPage as MainPage;

            if (mainPage != null)
                mainPage.SetViewContent(contentView);
        }
    }
}
