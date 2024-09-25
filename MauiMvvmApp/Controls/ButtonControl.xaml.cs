using System.Windows.Input;

namespace MauiMvvmApp.Controls;

public partial class ButtonControl : ContentView
{
    public ButtonControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(
            propertyName: nameof(Command),
            returnType: typeof(ICommand),
            declaringType: typeof(ButtonControl));

    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(
            propertyName: nameof(CommandParameter),
            returnType: typeof(object),
            declaringType: typeof(ButtonControl));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object CommandParameter
    {
        get => (object)GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }
}
