namespace TaskPlanner.Pages;

public partial class PasswordPage : ContentPage
{
	public PasswordPage()
	{
		InitializeComponent();
	}

    void ToHomePgBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync(HomePage);
    }
}
