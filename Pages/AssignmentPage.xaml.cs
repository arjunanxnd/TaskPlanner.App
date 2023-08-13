using System.Collections.ObjectModel;
using TaskPlanner.Business_Logic;

namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class AssignmentPage : ContentPage
{
    User _user;
    public User CurrentUser { get { return _user; } }
    Assignment _selectedAssignment;

    public AssignmentPage()
	{
		InitializeComponent();
        BindingContext = this;
	}
    
    private void AssignmentCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }

        _selectedAssignment = (Assignment)AssignmentCategoryPicker.SelectedItem;
    }

    private void OnClickAddAssignment(object sender, EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }

        string sub = SubjectEntry.Text;
        string desccription = DescriptionEdt.Text;
        DateOnly dueDate = DateOnly.FromDateTime(DueDatePicker.Date);

        Assignment assignment = new Assignment(sub, desccription, dueDate);
        _user.AddAssignment(assignment);

        foreach ( Assignment assignment1 in _user.AssignmentList)
        {
            if(assignment1 == assignment)
            {
                DisplayAlert("Info", $"{assignment} added", "OK");
            }
        }

        AssignmentCategoryPicker.ItemsSource = null;
        AssignmentCategoryPicker.ItemsSource = _user.AssignmentList;

    }

    private void OnClickDeleteAssignment(object sender, EventArgs e)
    {

    }
}

    

