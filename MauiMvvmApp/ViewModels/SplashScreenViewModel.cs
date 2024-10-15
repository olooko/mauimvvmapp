using CommunityToolkit.Mvvm.Input;
using MauiMvvmApp.Services;
using MauiMvvmApp.Views;

namespace MauiMvvmApp.ViewModels
{
    public partial class SplashScreenViewModel : ViewModelBase
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly INavigationService _navigationService;

        public SplashScreenViewModel(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
            _navigationService = _serviceProvider.GetRequiredService<INavigationService>();
        }

        [RelayCommand]
        private async Task GotoDefault()
        {
            await Task.Delay(1000);

            _navigationService.SetContent(_serviceProvider.GetRequiredService<DefaultView>());
        }

    }
}
