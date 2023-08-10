using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
    }

    private async void LogOutBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        bool isAnswered = await DisplayAlert("Log-out?", "Do you want to Log-out?", "Yes", "No");
        if (isAnswered)
            await Shell.Current.GoToAsync("//LoginPage");
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
