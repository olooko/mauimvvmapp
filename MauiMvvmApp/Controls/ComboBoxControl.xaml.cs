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

        List<string> strings = new List<string>();
        strings.Add("A");
        strings.Add("B");
        strings.Add("C");
        strings.Add("D");
        strings.Add("E");
        strings.Add("F");

        mainPage!.ShowComboBoxContent(strings);
    }
}