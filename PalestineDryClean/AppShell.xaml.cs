using PalestineDryClean.Views;
using PalestineDryClean.Views.Pages;

namespace PalestineDryClean;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("HomePage", typeof(HomePage));
		Routing.RegisterRoute("HomePage/CustomOrderPage", typeof(CustomOrderPage));
	}
}
