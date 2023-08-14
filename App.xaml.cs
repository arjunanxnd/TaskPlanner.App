namespace TaskPlanner;

public partial class App : Application
{
	public App()
	{
		try
		{
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cWGhAYVJ0WmFZfV1gdVRMYlhbQH5PIiBoS35RdUVrWHxcc3ZRQmlbUEF0");
			InitializeComponent();

			MainPage = new AppShell();

		}catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
