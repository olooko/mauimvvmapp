using System.Windows.Input;

namespace MauiMvvmApp.Controls;

public partial class RadioButtonControl : ContentView
{
	public RadioButtonControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(
            propertyName: nameof(Value),
            returnType: typeof(object),
            declaringType: typeof(RadioButtonControl));

    public static readonly BindableProperty CheckedChangedCommandProperty =
        BindableProperty.Create(
            propertyName: nameof(CheckedChangedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(RadioButtonControl));

    public object Value
    {
        get => (object)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public ICommand CheckedChangedCommand
    {
        get => (ICommand)GetValue(CheckedChangedCommandProperty);
        set => SetValue(CheckedChangedCommandProperty, value);
    }
}