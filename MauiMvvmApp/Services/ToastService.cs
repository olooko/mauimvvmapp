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
            MainPage? page = App.Current!.MainPage as MainPage;
            page!.ShowToastContent(toastBase);
        }
    }
}
