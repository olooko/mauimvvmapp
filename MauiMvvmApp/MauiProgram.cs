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
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IPopupService, PopupService>();

            builder.Services.AddTransient<SplashScreenView>();

            return builder.Build();
        }
    }
}
