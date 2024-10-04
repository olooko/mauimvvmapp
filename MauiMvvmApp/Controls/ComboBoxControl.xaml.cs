using MauiMvvmApp.Models;

namespace MauiMvvmApp.Controls;

public partial class ComboBoxControl : ContentView
{
	public ComboBoxControl()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        MainPage? mainPage = App.Current!.MainPage as MainPage;

        List<ComboBoxItemModel> items = new List<ComboBoxItemModel>();
        items.Add(new ComboBoxItemModel { Text = "A", Value = 1.1 });
        items.Add(new ComboBoxItemModel { Text = "B", Value = 2.2 });
        items.Add(new ComboBoxItemModel { Text = "C", Value = 3.3 });
        items.Add(new ComboBoxItemModel { Text = "D", Value = 4.4 });
        items.Add(new ComboBoxItemModel { Text = "E", Value = 5.5 });
        items.Add(new ComboBoxItemModel { Text = "F", Value = 6.6 });

        mainPage!.ShowComboBoxContent(items);
    }
}