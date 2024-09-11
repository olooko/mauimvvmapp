using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Services
{
    public interface IToastService
    {
        public void ShowContent(ContentView contentView);
    }

    public class ToastService : IToastService
    {
        public void ShowContent(ContentView contentView)
        {
            MainPage? page = App.Current!.MainPage as MainPage;
            page!.ShowToastContent(contentView);
        }
    }
}
