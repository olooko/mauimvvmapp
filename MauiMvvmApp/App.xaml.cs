using MauiMvvmApp.Views;

namespace MauiMvvmApp
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage page = new MainPage();
            page.SetViewContent(serviceProvider.GetRequiredService<SplashScreenView>());

            this.MainPage = page;
        }
    }
}
