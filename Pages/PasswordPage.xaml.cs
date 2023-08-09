namespace TaskPlanner.Pages;

public partial class PasswordPage : ContentPage
{
	public PasswordPage()
	{
		InitializeComponent();
	}

    public async void ToHomePgBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//Home");
    }
}
