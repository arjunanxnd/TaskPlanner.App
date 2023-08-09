namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class SignUpPage : ContentPage
{
    private UserRepository _repository;
    private User _user;
    public SignUpPage()
	{
		InitializeComponent();
        _repository = new UserRepository();
    }

    private async void ToPsswrdPgBtn_Clicked(System.Object sender, System.EventArgs e)
    {

        string uName = UsernameEntry.Text;
        string email = EmailEntry.Text;
        string firstALast = FirstALastEntry.Text;
        string password = await DisplayPromptAsync("Password", "Please remember your password!");
        _user = new User(uName, firstALast, email, password);

        _repository.

        await Shell.Current.GoToAsync("//Home");
    }
}
