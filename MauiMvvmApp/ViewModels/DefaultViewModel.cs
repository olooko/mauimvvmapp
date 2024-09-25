using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmApp.Toasts;
using MauiMvvmApp.Dialogs;
using MauiMvvmApp.Services;

namespace MauiMvvmApp.ViewModels
{
    public partial class DefaultViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IToastService _toastService;
        private readonly IDialogService _dialogService;

        [ObservableProperty]
        private object? _radioButtonValue;

        public DefaultViewModel(IServiceProvider serviceProvider)
        {
            _navigationService = serviceProvider.GetRequiredService<INavigationService>();
            _toastService = serviceProvider.GetRequiredService<IToastService>();
            _dialogService = serviceProvider.GetRequiredService<IDialogService>();

            _radioButtonValue = "Radio2";
        }

        [RelayCommand]
        private void Hello()
        {
            _toastService.ShowContent(new AlertToast("Hello"));
        }

        [RelayCommand]
        private void Dialog()
        {
            AlertDialog dialog = new AlertDialog();
            dialog.Title = "Dialog";
            dialog.Text = "This is Sample.";

            _dialogService.ShowContent(dialog);

            _toastService.ShowContent(new AlertToast(dialog.Text));
        }

        [RelayCommand]
        private void RadioButtonCheckedChanged(CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                _toastService.ShowContent(new AlertToast((string)this.RadioButtonValue!));
        }

        [RelayCommand]
        private void CheckBoxCheckedChanged(bool isChecked)
        {
            _toastService.ShowContent(new AlertToast(isChecked.ToString()));
        }
    }
}
