﻿namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;
using TaskPlanner.Data_Access;

public partial class LoginPage : ContentPage
{
    JSONDataManager _manager;
    UserRepository _repository;
    private string _fileName = "userData.json"; 
    private string _csvFilename = "user.csv";

    public LoginPage()
	{
		InitializeComponent();
        string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, _fileName);
        string csvFilePath = Path.Combine(FileSystem.Current.AppDataDirectory, _csvFileName);

        _manager = new JSONDataManager(filePath, csvFilePath);

        _repository = new UserRepository();
    }

    private async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            
            string uName = UserNameEntry.Text;
            string pass = PasswordEntry.Text;
            if (uName == null && pass == null)
                throw new Exception("Please Enter full details to proceed");

            foreach (User user in _repository.Users)
            {
                if (user.UserName == uName && user.Password == pass)
                {
                    await DisplayAlert("Welcome", $"{user.FirstAndLastName}", "OK");
                    await Shell.Current.GoToAsync("///Home");
                    break;
                }
            }
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
