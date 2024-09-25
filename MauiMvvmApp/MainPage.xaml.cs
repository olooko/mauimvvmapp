using MauiMvvmApp.Dialogs;
using MauiMvvmApp.Toasts;

namespace MauiMvvmApp
{
    public partial class MainPage : ContentPage
    {
        private static EventWaitHandle ewh;

        public MainPage()
        {
            InitializeComponent();

            ewh = new EventWaitHandle(false, EventResetMode.AutoReset);
        }

        public void SetViewContent(ContentView? contentView)
        {
            if (contentView != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                this.ViewContainer.Content = contentView;
            }
        }

        public void ShowDialogContent(DialogBase? dialogBase)
        {
            if (dialogBase != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                dialogBase.Parent = this.DialogContainer;

                this.DialogContainer.Opacity = 1.0;
                this.DialogContainer.IsVisible = true;
                this.DialogContainer.Content = dialogBase;

                //ewh.WaitOne();
            }
        }

        public async void ShowToastContent(ToastBase? toastBase)
        {
            if (toastBase != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                toastBase.Parent = this.ToastContainer;

                this.ToastContainer.IsVisible = true;
                this.ToastContainer.Content = toastBase;

                await this.ToastContainer.FadeTo(1, 1000, Easing.CubicOut);
                await this.ToastContainer.FadeTo(1, 4000);
                await this.ToastContainer.FadeTo(0, 1000, Easing.CubicIn);
            }
        }
    }

}
