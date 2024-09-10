using MauiMvvmApp.ViewModels;

namespace MauiMvvmApp.Views;

public partial class SplashScreenView : ContentView
{
	public SplashScreenView(SplashScreenViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}