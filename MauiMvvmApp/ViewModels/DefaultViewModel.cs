using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmApp.Contents;
using MauiMvvmApp.Services;

namespace MauiMvvmApp.ViewModels
{
    public partial class DefaultViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly INavigationService _navigationService;
        private readonly IToastService _toastService;

        [ObservableProperty]
        private object? _radioButtonValue;

        public DefaultViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _navigationService = _serviceProvider.GetRequiredService<INavigationService>();
            _toastService = _serviceProvider.GetRequiredService<IToastService>();

            _radioButtonValue = "Radio2";
        }

        [RelayCommand]
        private void Hello()
        {
            _toastService.ShowContent(new AlertContent("Hello"));
        }

        [RelayCommand]
        private void RadioButtonCheckedChanged(CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                _toastService.ShowContent(new AlertContent((string)this.RadioButtonValue));
        }

        [RelayCommand]
        private void CheckBoxCheckedChanged(bool isChecked)
        {
            _toastService.ShowContent(new AlertContent(isChecked.ToString()));
        }
    }
}
