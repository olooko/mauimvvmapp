using MauiMvvmApp.ViewModels;

namespace MauiMvvmApp.Views;

public partial class DataView : ContentView
{
	public DataView(DataViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}
}