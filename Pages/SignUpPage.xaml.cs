namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class SignUpPage : ContentPage
{
    private UserRepository _repository;
    private User _user;
    public SignUpPage(UserRepository repository)
	{
		InitializeComponent();
        _repository = repository;
    }

    private async void ToPsswrdPgBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            
            if (UsernameEntry == null && EmailEntry == null && FirstALastEntry == null)
                throw new Exception("Please fill all the Details before proceeding");
            string uName = UsernameEntry.Text;
            string email = EmailEntry.Text;
            string firstALast = FirstALastEntry.Text;
            string password = await DisplayPromptAsync("Password", "Please remember your password!");
            if (string.IsNullOrEmpty(password)) throw new Exception("Password cannot be empty");

            if (_repository.Users == null)
            {
                _user = new User(uName, firstALast, email, password);
            }
            if (_repository.Users != null)
            {
                foreach (User user in _repository.Users)
                {
                    if (user.UserName == uName)
                        throw new Exception("This user name Exists\nTry using different one");
                }
                _user = new User(uName, firstALast, email, password);
            }

            _repository.AddUser(_user);
            if (_repository.Users.Count() >= 1)
            {
                await DisplayAlert("Info", $"User {_user} added", "OK");
                await Navigation.PopToRootAsync();
            }
            else
                throw new Exception("User List did not populate");
        }catch(Exception ex)
        {
            DisplayAlert("Error", $"{ex.Message}", "OK");
        }
    }
}
