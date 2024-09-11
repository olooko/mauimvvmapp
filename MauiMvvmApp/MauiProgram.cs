using CommunityToolkit.Maui;
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

            builder.Services.AddTransient<SplashScreenView>();
            builder.Services.AddTransient<DefaultView>();

            builder.Services.AddTransient<SplashScreenViewModel>();
            builder.Services.AddTransient<DefaultViewModel>();

            return builder.Build();
        }
    }
}
