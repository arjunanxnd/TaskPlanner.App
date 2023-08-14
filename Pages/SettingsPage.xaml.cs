namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class SettingsPage : ContentPage
{
    User _user;
    public User CurrentUser { get { return _user; } }
    public SettingsPage()
	{
		InitializeComponent();

    }

    private void OnClickUpdate(object sender, EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }

            string userName = UserNameEntry.Text;
            string name = UserNameEntry.Text;
            string password = PasswordEntry.Text;
            string email = EmailEntry.Text;
             
            if(_user.UserName != userName) 
                _user.UpdateUserName(_user, userName);
            if(_user.FirstAndLastName != name)
                _user.UpdateFirstAndLast(_user, name);
            if(_user.Password != password)
                _user.UpdateUserpassword(_user, password);  
            if(_user.E_mail != email)
                _user.UpdateEmail(_user, email);    
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    private async void OnClickLogOut(object sender, EventArgs e)
    {
        bool isAnswered = await DisplayAlert("Log-out?", $"Do you want to Log-out {_user}?", "Yes", "No");
        if (isAnswered)
        {
            await Shell.Current.GoToAsync("//LoginPage");
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
        }
    }
}