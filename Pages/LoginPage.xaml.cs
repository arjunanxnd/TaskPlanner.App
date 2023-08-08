namespace TaskPlanner.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginSucsflBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        
    }

    private async void SignUpBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        SignUpPage signUpPage = new SignUpPage();
        await Navigation.PushAsync(signUpPage);
    }
}
