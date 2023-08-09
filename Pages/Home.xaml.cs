namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        RemovePage();
    }

    private async void RemovePage()
    {
        Navigation.RemovePage(new LoginPage());
    }
}
