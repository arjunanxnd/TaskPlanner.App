namespace TaskPlanner;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cVWhAYVRpR2NbfE5xdV9DZlZUQ2YuP1ZhSXxQdk1iWn5bcHxXTmVVVEc=");
		InitializeComponent(); 
		
        MainPage = new AppShell();
	}
}
