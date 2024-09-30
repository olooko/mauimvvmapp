using MauiMvvmApp.ViewModels;

namespace MauiMvvmApp.Views;

public partial class ColorView : ContentView
{
	public ColorView(ColorViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}