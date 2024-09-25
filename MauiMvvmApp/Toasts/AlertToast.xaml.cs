namespace MauiMvvmApp.Toasts;

public partial class AlertToast : ToastBase
{
	public AlertToast(string message)
	{
		InitializeComponent();

		this.Message.Text = message;
	}
}