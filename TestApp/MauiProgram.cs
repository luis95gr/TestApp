using AppActions.Icons.Maui;
using CommunityToolkit.Maui;
using DevExpress.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Sharpnado.Tabs;
using Syncfusion.Maui.Core.Hosting;
using TestApp.DI;

namespace TestApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>().UseMauiCommunityToolkit().ConfigureMopups().ConfigureViewModels().ConfigureServices().ConfigureViews().UseDevExpress().ConfigureSyncfusionCore().UseSharpnadoTabs(loggerEnable:false)

			.ConfigureEssentials(essentials =>
            {
                essentials
                    .UseAppActionIcons(); // Add this line
            })

            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

