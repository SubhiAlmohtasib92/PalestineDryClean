using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PalestineDryClean.ViewModels;
using PalestineDryClean.Views;
using PalestineDryClean.Views.Pages;
using Syncfusion.Maui.Core.Hosting;

namespace PalestineDryClean;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Tajawal-Regular.ttf", "TajawalRegular");
			});

#if DEBUG
        builder.Logging.AddDebug();
#endif
		builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<CustomOrderPage>();
		builder.Services.AddTransient<CustomOrdersPageViewModel>();
		return builder.Build();
	}
}
