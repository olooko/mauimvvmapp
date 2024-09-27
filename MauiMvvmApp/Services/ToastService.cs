using MauiMvvmApp.Toasts;

namespace MauiMvvmApp.Services
{
    public interface IToastService
    {
        public void ShowContent(ToastBase toastBase);
    }

    public class ToastService : IToastService
    {
        public void ShowContent(ToastBase toastBase)
        {
            MainPage? mainPage = App.Current!.MainPage as MainPage;
            mainPage!.ShowToastContent(toastBase);
        }
    }
}
