using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

	public void SaveProducts(JSONDataManager dataManager)
	{
		dataManager.WriteUserInformation();
	}
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
    }

}
