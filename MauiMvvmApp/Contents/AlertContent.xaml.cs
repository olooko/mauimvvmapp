namespace MauiMvvmApp.Contents;

public partial class AlertContent : ContentView
{
	public AlertContent(string message)
	{
		InitializeComponent();

		this.Message.Text = message;
	}
}