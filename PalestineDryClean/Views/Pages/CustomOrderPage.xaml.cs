using PalestineDryClean.ViewModels;

namespace PalestineDryClean.Views.Pages;

public partial class CustomOrderPage : ContentPage
{
    private readonly CustomOrdersPageViewModel customOrdersPageViewModel;
	public CustomOrderPage(CustomOrdersPageViewModel customOrdersPageViewModel)
	{
		InitializeComponent();
        this.customOrdersPageViewModel = customOrdersPageViewModel;
        BindingContext = customOrdersPageViewModel;
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        await customOrdersPageViewModel.SetCustomOrderList();
    }
}