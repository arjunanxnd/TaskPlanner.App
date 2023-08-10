using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
    }
        
        
    

	/*public void SaveProducts(JSONDataManager dataManager)
	{
		dataManager.WriteUserInformation();
	}*/
        
    
	//public void SaveProducts(JSONDataManager dataManager)
	//{
	//	dataManager.WriteUserInformation();
	//}

}
