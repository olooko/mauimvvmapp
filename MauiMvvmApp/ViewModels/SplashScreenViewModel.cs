using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmApp.Services;
using MauiMvvmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.ViewModels
{
    public partial class SplashScreenViewModel : ObservableObject
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
            await Task.Delay(2000);

            _navigationService.SetContent(_serviceProvider.GetRequiredService<DefaultView>());
        }

    }
}
