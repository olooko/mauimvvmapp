using MauiMvvmApp.Dialogs;

namespace MauiMvvmApp.Services
{
    public interface IDialogService
    {
        public Task ShowContent(DialogBase dialogBase);
    }

    public class DialogService : IDialogService
    {
        public async Task ShowContent(DialogBase dialogBase)
        {
            MainPage? page = App.Current!.MainPage as MainPage;
            await page!.ShowDialogContent(dialogBase);
        }
    }
}
