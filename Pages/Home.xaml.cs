using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        RemovePage();
    }

	/*public void SaveProducts(JSONDataManager dataManager)
	{
		dataManager.WriteUserInformation();
	}*/
        
    

    private async void RemovePage()
    {
        Navigation.RemovePage(new LoginPage());
    }
}
