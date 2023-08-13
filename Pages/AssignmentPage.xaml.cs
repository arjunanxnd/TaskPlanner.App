using System.Collections.ObjectModel;
using TaskPlanner.Business_Logic;

namespace TaskPlanner.Pages;

public partial class AssignmentPage : ContentPage
{
    

    public AssignmentPage()
	{
		InitializeComponent();
	}
    
    private void AssignmentCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void OnClickAddAssignment(object sender, EventArgs e)
    {

    }

    private void OnClickDeleteAssignment(object sender, EventArgs e)
    {

    }

    private void OnCalendarTapped(object sender, Syncfusion.Maui.Calendar.CalendarTappedEventArgs e)
    {
        var selectedDate = e.Date;
        var calendarElement = e.Element;

        

    }

    private void DueDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var selectedDate = e.NewDate;
        Calendar.SelectedDates.Clear();
        Calendar.SelectedDates.Add(selectedDate);
    }
}

    

