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

    private async void OnClickLogOut(object sender, EventArgs e)
    {
        bool isAnswered = await DisplayAlert("Log-out?", $"Do you want to Log-out {_user}?", "Yes", "No");
        if (isAnswered)
        {
            await Shell.Current.GoToAsync("//LoginPage");
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
        }
    }

    void UserSwitch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            if (UserSwitch.IsToggled)
            {
                UserNameEntry.Placeholder = _user.UserName;
                NameEntry.Placeholder = _user.FirstAndLastName;
                PasswordEntry.Placeholder = _user.Password;
                EmailEntry.Text = _user.E_mail;
            }

            if (!UserSwitch.IsToggled)
            {
                UserNameEntry.Placeholder = "Enter New UserName";
                NameEntry.Placeholder = "Enter New Name";
                PasswordEntry.Placeholder = "Enter New Password";
                EmailEntry.Text = "Enter New Email";
            }
            
        }catch(Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    void Namebtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            string name = NameEntry.Text;
            _user.UpdateFirstAndLast(_user, name);
            DisplayAlert("Info", $"Your Name has been set to {_user.FirstAndLastName}", "OK");
            NameEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    void UpdateUserNameBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            string userName = UserNameEntry.Text;

            foreach(User user1 in UserRepository.Users)
            {
                if (user1.UserName == userName)
                    throw new Exception("This user has been Occupied\nTry a different one");
            } 
            _user.UpdateUserName(_user, userName);
            DisplayAlert("Info", $"Your UserName has been set to {_user.UserName}", "OK");
            UserNameEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    void UpdateUserEmailEntry_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {

            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            string email = EmailEntry.Text;
            _user.UpdateEmail(_user, email);
            DisplayAlert("Info", $"Your Email has been set to {_user.E_mail}", "OK");
            EmailEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    void UpdatePasswordBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            string password = PasswordEntry.Text;
            _user.UpdateUserpassword(_user, password);
            DisplayAlert("Info", $"Your Password has been changed", "OK");
            PasswordEntry.Text = "";
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }
}