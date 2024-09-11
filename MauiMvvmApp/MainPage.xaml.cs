namespace MauiMvvmApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SetViewContent(ContentView? contentView)
        {
            if (contentView != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                this.ViewContent.Content = contentView;
            }
        }

        public void ShowDialogContent(ContentView? contentView)
        {
            if (contentView != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                contentView.Parent = this.DialogContent;

                this.DialogContent.Opacity = 1.0;
                this.DialogContent.IsVisible = true;
                this.DialogContent.Content = contentView;
            }
        }

        public async void ShowToastContent(ContentView? contentView)
        {
            if (contentView != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                contentView.Parent = this.ToastContent;

                this.ToastContent.IsVisible = true;
                this.ToastContent.Content = contentView;

                await this.ToastContent.FadeTo(1, 1000, Easing.CubicOut);
                await this.ToastContent.FadeTo(1, 4000);
                await this.ToastContent.FadeTo(0, 1000, Easing.CubicIn);
            }
        }
    }

}
