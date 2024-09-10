using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using MauiMvvmApp.Services;
using MauiMvvmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.ViewModels
{
    public partial class DefaultViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly INavigationService _navigationService;

        public DefaultViewModel(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
            _navigationService = _serviceProvider.GetRequiredService<INavigationService>();
        }

    }
}
