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

        public void ShowPopupContent(ContentView? contentView)
        {
            if (contentView != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                contentView.Parent = this.PopupContent;

                this.PopupContent.Opacity = 1.0;
                this.PopupContent.IsVisible = true;
                this.PopupContent.Content = contentView;
            }
        }
    }

}
