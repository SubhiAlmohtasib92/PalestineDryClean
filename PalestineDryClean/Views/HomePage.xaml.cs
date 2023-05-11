namespace PalestineDryClean.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Custom_Order_Btn_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//HomePage/CustomOrderPage");
    }
}