namespace TaskPlanner.Pages;
using TaskPlanner.Business_Logic;
using System.Collections.ObjectModel;

public partial class MyPopups
{
	public ObservableCollection<Exam> Exams { get; set; }
	public ObservableCollection<Assignment> Assignments { get; set; }
	public ObservableCollection<General> Generals { get; set; }
    public string VarContents { get; private set; }

	public MyPopups(string currentContent, ObservableCollection<Assignment> assignments, ObservableCollection<Exam> exams, ObservableCollection<General> generals)
	{
		InitializeComponent();

        BindingContext = this;

        VarContents = currentContent;
        Exams = exams;
		Assignments = assignments;
		Generals = generals;

        if (VarContents == "ASSIGNMENT")
        {
            //ContentsView.ItemsSource = null;
            CurrentContent.Text = VarContents;
            ContentsView.ItemsSource = Assignments;
        }
        if (VarContents == "EXAM")
        {
            CurrentContent.Text = VarContents;
            ContentsView.ItemsSource = Exams;
        }
        if (VarContents == "GENERAL")
        {
            //ContentsView.ItemsSource = null;
            CurrentContent.Text = VarContents;
            ContentsView.ItemsSource = Generals;
        }

        //MyFunction(VarContents);
	}

	//private List<General> MyFunction(string variable)
	//{
        
 //   }
}
