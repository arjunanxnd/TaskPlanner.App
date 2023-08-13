using TaskPlanner.Business_Logic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Mopups;
using Mopups.Pages;
using Mopups.Services;

namespace TaskPlanner.Pages;

public partial class Home : ContentPage, INotifyPropertyChanged
{
    User _user;
    private string _strAccess;
    public string StrAccess { get { return _strAccess; } set { _strAccess = value; OnPropertyChanged(); } }

    private List<string> _displayContents;
    public List<string> DisplayContents { get { return _displayContents; } }

    public ObservableCollection<Assignment> CurrentAssignmentaList { get { return _user.AssignmentList; } }
    public ObservableCollection<Exam> CurrentExamList { get { return _user.ExamList; } }
    public ObservableCollection<General> CurrentGeneralList { get { return _user.GeneralList; } }

    public Home()
    {
        InitializeComponent();

        _displayContents = new List<string> { "ASSIGNMENT","EXAMS","GENERAL" };

        BindingContext = this;
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

    private void ViewBtn_Clicked(object sender, EventArgs e)
    {


        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }
        DisplayAlert("Info", $"Current user is {_user}", "OK");

        if(StrAccess == "ASSIGNMENT")
        {
            ContentsView.ItemsSource = null;
            ContentsView.ItemsSource = CurrentAssignmentaList;
        }
        else if(StrAccess == "EXAM")
        {
            ContentsView.ItemsSource = null;
            ContentsView.ItemsSource = CurrentExamList;
        }
        else if(StrAccess == "GENERAL")
        {
            ContentsView.ItemsSource = null;
            ContentsView.ItemsSource = CurrentGeneralList;
        }

        MopupService.Instance.PushAsync(new MyPopups());

        //switch (StrAccess)
        //{
        //    case "ASSIGNMENT":
        //        ContentsView.ItemsSource = null;
        //        ContentsView.ItemsSource = CurrentAssignmentaList;
        //        break;
        //    case "EXAM":
        //        ContentsView.ItemsSource = null;
        //        ContentsView.ItemsSource = CurrentExamList;
        //        break;
        //    case "GENERAL":
        //        ContentsView.ItemsSource = null;
        //        ContentsView.ItemsSource = CurrentGeneralList;
        //        break;
        //}

    }
}
