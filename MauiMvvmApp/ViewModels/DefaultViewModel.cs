using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmApp.Toasts;
using MauiMvvmApp.Dialogs;
using MauiMvvmApp.Models;
using MauiMvvmApp.Services;
using System.Collections.ObjectModel;

namespace MauiMvvmApp.ViewModels
{
    public partial class DefaultViewModel : ViewModelBase
    {
        private readonly IApplicationService _applicationService;
        private readonly INavigationService _navigationService;
        private readonly IToastService _toastService;
        private readonly IDialogService _dialogService;

        [ObservableProperty]
        private object? _radioButtonValue;

        [ObservableProperty]
        private ObservableCollection<ComboBoxItemModel> _comboBoxList;


        public DefaultViewModel(IServiceProvider serviceProvider)
        {
            _applicationService = serviceProvider.GetRequiredService<IApplicationService>();
            _navigationService = serviceProvider.GetRequiredService<INavigationService>();
            _toastService = serviceProvider.GetRequiredService<IToastService>();
            _dialogService = serviceProvider.GetRequiredService<IDialogService>();

            _radioButtonValue = "Light";

            _comboBoxList = new ObservableCollection<ComboBoxItemModel>();
            _comboBoxList.Add(new ComboBoxItemModel { Text = "A", Value = 1.1 });
            _comboBoxList.Add(new ComboBoxItemModel { Text = "B", Value = 2.2 });
            _comboBoxList.Add(new ComboBoxItemModel { Text = "C", Value = 3.3 });
            _comboBoxList.Add(new ComboBoxItemModel { Text = "D", Value = 4.4 });
            _comboBoxList.Add(new ComboBoxItemModel { Text = "E", Value = 5.5 });
            _comboBoxList.Add(new ComboBoxItemModel { Text = "F", Value = 6.6 });
        }

        [RelayCommand]
        private void Hello()
        {
            _toastService.ShowContent(new AlertToast("Hello"));
        }

        [RelayCommand]
        private async Task Dialog()
        {
            AlertDialog dialog = new AlertDialog();
            dialog.Title = "Dialog";
            dialog.Text = "This is Sample.";

            if (await _dialogService.ShowContent(dialog))
            {
                _toastService.ShowContent(new AlertToast(dialog.Text));
            }
        }

        partial void OnRadioButtonValueChanged(object? value)
        {
            _applicationService.ChangeTheme((string)value!);
            //    _toastService.ShowContent(new AlertToast((string)this.RadioButtonValue!));
        }

        [RelayCommand]
        private void RadioButtonCheckedChanged(CheckedChangedEventArgs e)
        {
            //if (e.Value == true)
            //{
            //    _applicationService.ChangeTheme((string)this.RadioButtonValue!);
            //    _toastService.ShowContent(new AlertToast((string)this.RadioButtonValue!));
            //}
        }

        [RelayCommand]
        private void CheckBoxCheckedChanged(bool isChecked)
        {
            _toastService.ShowContent(new AlertToast(isChecked.ToString()));
        }

        [RelayCommand]
        private void ComboBoxSelectionChanged(object parameter)
        {
            var itemModel = parameter as ComboBoxItemModel;

            _toastService.ShowContent(new AlertToast(itemModel.Value.ToString()));
        }
    }
}
