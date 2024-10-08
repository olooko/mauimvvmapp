namespace MauiMvvmApp.Dialogs;

public partial class AlertDialog : DialogBase
{
	public string Title 
	{
		get => this.TitleLabel.Text;
		set => this.TitleLabel.Text = value; 
	}

    public string Text
    {
        get => this.TextEntry.Text;
        set => this.TextEntry.Text = value;
    }

    public AlertDialog()
	{
		InitializeComponent();
	}

    private void OkButton_Clicked(object sender, EventArgs e)
    {
		this.Close(true);
    }

    private void CancelButton_Clicked(object sender, EventArgs e)
    {
        this.Close(false);
    }
}