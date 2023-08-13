namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;

public partial class ExamPage : ContentPage
{
    User _user;
    public User CurrentUser { get { return _user; } }
    Exam _selectedExam;

    public ExamPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void OnClickAddExam(object sender, EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }

        string sub = SubjectEntry.Text;
        string description = DescriptionEdt.Text;
        DateOnly dueDate = DateOnly.FromDateTime(DueDatePicker.Date);
        ExamType etype = ExamType.Quiz;

        if (string.IsNullOrEmpty(sub) || string.IsNullOrEmpty(description))
            throw new Exception("Please enter all the details");

        if (QuizRb.IsChecked)
            etype = ExamType.Quiz;
        else if (MidTermRb.IsChecked)
            etype = ExamType.MidTerms;
        else if (FinalRb.IsChecked)
            etype = ExamType.FinalExam;

        Exam exam = new Exam(sub, description, dueDate, etype);
        _user.AddExam(exam);

        foreach (Exam assignment1 in _user.ExamList)
        {
            if (assignment1 == exam)
            {
                DisplayAlert("Info", $"{exam} added", "OK");
            }
        }

        ExamCategoryPicker.ItemsSource = null;
        ExamCategoryPicker.ItemsSource = _user.ExamList;
    }

    private void OnClickDeleteExam(object sender, EventArgs e)
    {
        try
        {
            foreach (User user in UserRepository.Users)
            {
                if (user.userId == UserRepository.CurrentUID)
                    _user = user;
            }
            var copyAssignment = _selectedExam;
            _user.DeleteExam(_selectedExam);

            DisplayAlert("Info", $"{copyAssignment} Deleted", "OK");
            ExamCategoryPicker.ItemsSource = null;
            ExamCategoryPicker.ItemsSource = _user.ExamList;
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"{ex}", "OK");
        }
    }

    private void ExamCategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (User user in UserRepository.Users)
        {
            if (user.userId == UserRepository.CurrentUID)
                _user = user;
        }

        _selectedExam = (Exam)ExamCategoryPicker.SelectedItem;
    }

    //private void QuizRadioButton(object sender, CheckedChangedEventArgs e)
    //{

    //}

    //private void MidtermRadioButton(object sender, CheckedChangedEventArgs e)
    //{

    //}

    //private void FinalsRadioButton(object sender, CheckedChangedEventArgs e)
    //{

    //}
}
