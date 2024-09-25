using MauiMvvmApp.Dialogs;

namespace MauiMvvmApp.Services
{
    public interface IDialogService
    {
        public void ShowContent(DialogBase dialogBase);
    }

    public class DialogService : IDialogService
    {
        public void ShowContent(DialogBase dialogBase)
        {
            MainPage? page = App.Current!.MainPage as MainPage;
            page!.ShowDialogContent(dialogBase);
        }
    }
}
