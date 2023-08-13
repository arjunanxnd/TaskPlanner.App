using TaskPlanner.Business_Logic;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
    User _user;

    public Home()
    {
        InitializeComponent();
    }

    private async void LogOutBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        bool isAnswered = await DisplayAlert("Log-out?", $"Do you want to Log-out {_user}?", "Yes", "No");
        if (isAnswered)
        {
            await Shell.Current.GoToAsync("//LoginPage");
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
        }
    }

    private async void CheckBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.UserId == UserRepository.CurrentUID)
                _user = user;
        }
        DisplayAlert("Info", $"Current user is {_user}", "OK");
    }

    private void ViewBtn_Clicked(object sender, EventArgs e)
    {

    }
}
