using MauiMvvmApp.Controls;
using MauiMvvmApp.Dialogs;
using MauiMvvmApp.Models;
using MauiMvvmApp.Toasts;
using System.Threading.Tasks;

namespace MauiMvvmApp
{
    public partial class MainPage : ContentPage
    {
        private TaskCompletionSource<ComboBoxItemModel> _comboBoxCompletionSource;
        private CancellationToken _comboBoxToken;

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

        public async Task<ComboBoxItemModel> ShowComboBoxContent(IEnumerable<ComboBoxItemModel> items)
        {
            this.ComboBoxContent.Opacity = 1.0;
            this.ComboBoxContent.IsVisible = true;

            this.ComboBoxList.ItemsSource = items;
            
            _comboBoxCompletionSource = new TaskCompletionSource<ComboBoxItemModel>();
            _comboBoxToken = new CancellationToken();

            return await _comboBoxCompletionSource.Task.WaitAsync(_comboBoxToken);
        }

        public async Task<bool> ShowDialogContent(DialogBase? dialogBase)
        {
            if (dialogBase != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                dialogBase.Parent = this.DialogContent;

                this.DialogContent.Opacity = 1.0;
                this.DialogContent.IsVisible = true;
                this.DialogContent.Content = dialogBase;

                return await dialogBase.Modal();
            }
            return false;
        }

        public async void ShowToastContent(ToastBase? toastBase)
        {
            if (toastBase != null)
            {
                //contentView.Content.Scale = (DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density) / 1920;
                toastBase.Parent = this.ToastContent;

                this.ToastContent.IsVisible = true;
                this.ToastContent.Content = toastBase;

                await this.ToastContent.FadeTo(1, 1000, Easing.CubicOut);
                await this.ToastContent.FadeTo(1, 4000);
                await this.ToastContent.FadeTo(0, 1000, Easing.CubicIn);
            }
        }

        private void ComboBoxList_CancelButtonClicked(object sender, EventArgs e)
        {
            this.ComboBoxContent.Opacity = 0.0;
            this.ComboBoxContent.IsVisible = false;

            this.ComboBoxList.ItemsSource = null;
        }

        private void ComboBoxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _comboBoxCompletionSource.SetResult((ComboBoxItemModel)e.CurrentSelection[0]);

            this.ComboBoxContent.Opacity = 0.0;
            this.ComboBoxContent.IsVisible = false;

            this.ComboBoxList.ItemsSource = null;
        }
    }
}
