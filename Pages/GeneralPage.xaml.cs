using Syncfusion.Maui.Calendar;
using System.Globalization;
using TaskPlanner.Business_Logic;
namespace TaskPlanner.Pages;

public partial class GeneralPage : ContentPage
{
    User _user;
    public User CurrentUser { get { return _user; } }
    General _selectedGeneral;
    public GeneralPage()
	{
		InitializeComponent();
        BindingContext = this;
        this.Calendar.SelectionMode = CalendarSelectionMode.Multiple;
    }

    private void OnClickAdd(object sender, EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }

            string title = TitleEntry.Text;
            string desccription = DescriptionEdt.Text;
            DateTime dueDate = DueDatePicker.Date;

            General general = new General(title, desccription, dueDate);
            _user.AddGeneral(general);

            DisplayAlert("Info", $"{general} added", "OK");

            TitleEntry.Text = "";
            DescriptionEdt.Text = "";

            GeneralCategoryPicker.ItemsSource = null;
            GeneralCategoryPicker.ItemsSource = _user.GeneralList;

            Calendar.SelectedDates.Clear();
            Calendar.SelectedDates.Add(dueDate);
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

   
    private void OnClickDelete(object sender, EventArgs e)
    {

    }

    private void GeneralCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }
        _selectedGeneral = (General)GeneralCategoryPicker.SelectedItem;
    }
}