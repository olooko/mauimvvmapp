﻿using CommunityToolkit.Maui;
using MauiMvvmApp.Services;
using MauiMvvmApp.Views;
using MauiMvvmApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiMvvmApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IDialogService, DialogService>();
            builder.Services.AddSingleton<IToastService, ToastService>();
            builder.Services.AddSingleton<IApplicationService, ApplicationService>();

            builder.Services.AddTransient<SplashScreenView>();
            builder.Services.AddTransient<DefaultView>();
            builder.Services.AddTransient<DataView>();
            builder.Services.AddTransient<ColorView>();

            builder.Services.AddTransient<SplashScreenViewModel>();
            builder.Services.AddTransient<DefaultViewModel>();
            builder.Services.AddTransient<DataViewModel>();
            builder.Services.AddTransient<ColorViewModel>();

            return builder.Build();
        }
    }
}
