using System.Windows.Input;

namespace MauiMvvmApp.Controls;

public partial class ComboBoxItemControl : ContentView
{
	public ComboBoxItemControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(ComboBoxItemControl));

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(
            propertyName: nameof(Value),
            returnType: typeof(object),
            declaringType: typeof(ComboBoxItemControl));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public object Value
    {
        get => (object)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
}