using TaskPlanner.Business_Logic;
using TaskPlanner.Data_Access;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage
{
	UserRepository _userRepository = new UserRepository();

	string _jsonFileName = "userData.json";
	string _csvFileName = "user.csv";
	JSONDataManager _userDataManger;
    public UserRepository UserRepository { get { return _userRepository; } }
    public Home()
	{
		InitializeComponent();
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
		
		string jsonFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, _jsonFileName);
        string csvFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, _csvFileName);
        _userDataManger = new JSONDataManager(jsonFilePath, csvFilePath);	
        
    }

    
    private async void LogOutBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        bool isAnswered = await DisplayAlert("Log-out?", "Do you want to Log-out?", "Yes", "No");
        if (isAnswered)
            await Shell.Current.GoToAsync("//LoginPage");
    }



    public void SaveProducts(JSONDataManager dataManager)
	{
        _userRepository.SaveUser(_userDataManger);
	}
}
