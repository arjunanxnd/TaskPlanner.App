﻿namespace TaskPlanner.Pages;
using System.Reflection;
using TaskPlanner.Business_Logic;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        UserRepository.AddUser(new User("Demo", "XYZ", "xyz@gmail.com", "Demo123", null, null, null));
    }

    private async void LoginBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            string uName = UserNameEntry.Text;
            string pass = PasswordEntry.Text;
            if ((string.IsNullOrEmpty(uName) && string.IsNullOrEmpty(pass)) || (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(pass)))
                throw new Exception("Please Enter full details to proceed");


            foreach (User user in UserRepository.Users)
            {
                if (user.UserName == uName && user.Password == pass)
                {
                    UserRepository.CurrentUID = user.userId;
                    await DisplayAlert("Welcome", $"{user.FirstAndLastName}", "OK");
                    await Shell.Current.GoToAsync("////Home");
                    Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
                    //App.Current.MainPage = new Home();
                    break;
                }
            }
            UserNameEntry.Text="";
            PasswordEntry.Text="";
        }
        catch (TargetInvocationException er)
        {
            DisplayAlert("Error", $"{er.Message}", "OK");

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex.Message}", "OK");
        }
    }

    
    private async void SignUpLabel_Tapped(object sender, TappedEventArgs e)
    {
        SignUpPage signUpPage = new SignUpPage();
        await Navigation.PushAsync(signUpPage);
    }
}
