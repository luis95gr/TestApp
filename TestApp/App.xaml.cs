namespace TestApp;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTEzMDk1MEAzMjMwMmUzNDJlMzBRMUJ1amJyUVBqZ3cyRXFTQU1VUE9jYUFFRTZnR040K0ZkL1RJNFhsN2ZjPQ==");
        InitializeComponent();

		MainPage = new AppShell();
	}
}

