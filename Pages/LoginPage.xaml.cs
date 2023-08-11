namespace TaskPlanner.Pages;

using System.Reflection;
using TaskPlanner.Business_Logic;
using TaskPlanner.Data_Access;

public partial class LoginPage : ContentPage
{
    JSONDataManager _manager;
    UserRepository _repository;
    private string _fileName = "userData.json";

    public LoginPage()
	{
		InitializeComponent();
        FilePath.JsonFilename = Path.Combine(FileSystem.Current.AppDataDirectory, _fileName);
        _manager = new JSONDataManager();
        _manager.JsonFile = FilePath.JsonFilename;
        _repository = new UserRepository();
    }

    private async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            string uName = UserNameEntry.Text;
            string pass = PasswordEntry.Text;
            if (string.IsNullOrEmpty(uName) && string.IsNullOrEmpty(pass))
                throw new Exception("Please Enter full details to proceed");

            foreach (User user in _repository.Users)
            {
                if (user.UserName != uName && user.Password != pass)
                {
                    continue;
                }
                FilePath.CurrentUserId = user.UserId;
                await DisplayAlert("Welcome", $"{user.FirstAndLastName}", "OK");
                await Shell.Current.GoToAsync("///Home");
            }
        }
        catch(TargetInvocationException er)
        {
            DisplayAlert("Error", $"{er.Message}", "OK");

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex.Message}", "OK");
        }
    }

    private async void SignUpBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        SignUpPage signUpPage = new SignUpPage(_repository);
        await Navigation.PushAsync(signUpPage);
    }
}
