using MauiMvvmApp.Models;
using System.Windows.Input;

namespace MauiMvvmApp.Controls;

public partial class ComboBoxControl : ContentView
{
	public ComboBoxControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty DisplayTextProperty =
        BindableProperty.Create(
            propertyName: nameof(DisplayText),
            returnType: typeof(string),
            declaringType: typeof(ComboBoxControl));

    public static readonly BindableProperty ItemsSourceProperty =
        BindableProperty.Create(
            propertyName: nameof(ItemsSource),
            returnType: typeof(IEnumerable<ComboBoxItemModel>),
            declaringType: typeof(ComboBoxControl));

    public static readonly BindableProperty SelectionChangedCommandProperty =
        BindableProperty.Create(
            propertyName: nameof(SelectionChangedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(ComboBoxControl));

    public string DisplayText
    {
        get => (string)GetValue(DisplayTextProperty);
        set => SetValue(DisplayTextProperty, value);
    }

    public IEnumerable<ComboBoxItemModel> ItemsSource
    {
        get => (IEnumerable<ComboBoxItemModel>)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public ICommand SelectionChangedCommand
    {
        get => (ICommand)GetValue(SelectionChangedCommandProperty);
        set => SetValue(SelectionChangedCommandProperty, value);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        MainPage? mainPage = App.Current!.MainPage as MainPage;

        var item = await mainPage!.ShowComboBoxContent(this.ItemsSource);

        this.DisplayText = item.Text;
        
        SelectionChangedCommand.Execute(item);
    }
}