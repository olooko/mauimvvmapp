using MauiMvvmApp.ViewModels;

namespace MauiMvvmApp.Views;

public partial class DefaultView : ContentView
{
	public DefaultView(DefaultViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}