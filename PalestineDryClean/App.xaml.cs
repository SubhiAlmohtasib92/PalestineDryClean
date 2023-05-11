namespace PalestineDryClean;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTgzODcyMkAzMjMxMmUzMTJlMzQzMW1qK3ovLzN2LzV6OVNZb3JPS3NnRkZxZHA1bFUydVZ3a3FheTh1OU8rOGM9");
        MainPage = new AppShell();
	}


}
