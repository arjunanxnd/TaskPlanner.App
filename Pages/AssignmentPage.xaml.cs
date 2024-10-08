﻿using System.Collections.ObjectModel;
using TaskPlanner.Business_Logic;

namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class AssignmentPage : ContentPage
{
    User _user;
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
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }

            string sub = SubjectEntry.Text;
            string desccription = DescriptionEdt.Text;
            DateTime dueDate = DueDatePicker.Date;

            Assignment assignment = new Assignment(sub, desccription, dueDate);
            _user.AddAssignment(assignment);
            DisplayAlert("Info", $"{assignment} added", "OK");

            SubjectEntry.Text="";
            DescriptionEdt.Text="";

            AssignmentCategoryPicker.ItemsSource = null;
            AssignmentCategoryPicker.ItemsSource = _user.AssignmentList;

        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
        /*foreach (Assignment assignment2 in _user.AssignmentList)
        {
            Calendar.SelectedDates.Add(assignment.DueDate);
        }*/

    }

    void DeleteBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            var copyAssignment = _selectedAssignment;
            _user.DeleteAssignment(_selectedAssignment);

            DisplayAlert("Info", $"{copyAssignment} Deleted", "OK");
            AssignmentCategoryPicker.ItemsSource = null;
            AssignmentCategoryPicker.ItemsSource = _user.AssignmentList;
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }
}



