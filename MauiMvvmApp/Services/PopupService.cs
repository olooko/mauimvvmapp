using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Services
{
    public interface IPopupService
    {
        public void ShowContent(ContentView contentView);
    }

    public class PopupService : IPopupService
    {
        public void ShowContent(ContentView contentView)
        {
            MainPage? page = App.Current!.MainPage as MainPage;
            page!.ShowPopupContent(contentView);
        }
    }
}
