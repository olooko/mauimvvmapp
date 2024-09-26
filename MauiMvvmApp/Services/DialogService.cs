using MauiMvvmApp.Dialogs;

namespace MauiMvvmApp.Services
{
    public interface IDialogService
    {
        public Task<bool> ShowContent(DialogBase dialogBase);
    }

    public class DialogService : IDialogService
    {
        public async Task<bool> ShowContent(DialogBase dialogBase)
        {
            MainPage? page = App.Current!.MainPage as MainPage;
            return await page!.ShowDialogContent(dialogBase);
        }
    }
}
