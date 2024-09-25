using CommunityToolkit.Maui.Alerts;
using System.Windows.Input;

namespace MauiMvvmApp.Controls;

public partial class CheckBoxControl : ContentView
{
	public CheckBoxControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty IsCheckedProperty =
        BindableProperty.Create(
            propertyName: nameof(IsChecked),
            returnType: typeof(bool),
            declaringType: typeof(CheckBoxControl));

    public static readonly BindableProperty CheckedChangedCommandProperty =
        BindableProperty.Create(
            propertyName: nameof(CheckedChangedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(CheckBoxControl));

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public ICommand CheckedChangedCommand
    {
        get => (ICommand)GetValue(CheckedChangedCommandProperty);
        set => SetValue(CheckedChangedCommandProperty, value);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        this.IsChecked = !this.IsChecked;

        CheckedChangedCommand.Execute(this.IsChecked);
    }
}