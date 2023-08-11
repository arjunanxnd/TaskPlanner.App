using TaskPlanner.Business_Logic;
using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
    UserRepository _userRepository = new UserRepository();
	User _user;

	//JSONDataManager _userDataManger;
    public UserRepository UserRepository { get { return _userRepository; } }
    int userId = 0;

    public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
		
		//string jsonFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, _jsonFileName);
        //string csvFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, _csvFileName);
        //_userDataManger = new JSONDataManager(jsonFilePath);
        userId = FilePath.CurrentUserId;
        _userRepository.Users = _userRepository.LoadUsers(FilePath.JsonFilename);

        foreach (User user in _userRepository.Users)
        {
            if (user.UserId == userId)
                _user = user;
        }
    }

    
    private async void LogOutBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        
        bool isAnswered = await DisplayAlert("Log-out?", "Do you want to Log-out?", "Yes", "No");
        if (isAnswered)
            await Shell.Current.GoToAsync("//LoginPage");
    }



    /*public void SaveProducts(JSONDataManager dataManager)
	{
        _userRepository.SaveUser(_userDataManger);
	}*/

    private async void CheckBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        foreach(User user in _userRepository.Users)
        {
            if (userId == user.UserId)
            {
                await DisplayAlert("Info", $"Current user is {user}", "OK");
                break;
            }
        }
    }



}
