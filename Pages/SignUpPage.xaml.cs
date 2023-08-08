namespace TaskPlanner.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void ToPsswrdPgBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		PasswordPage passwordPage = new PasswordPage();
		await Navigation.PushAsync(PasswordPage);
    }
}
