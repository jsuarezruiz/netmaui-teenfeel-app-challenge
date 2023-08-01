using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using TeenFeel.Services;
using TeenFeel.Views;

namespace TeenFeel;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiCompatibility()
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Recoleta-Bold.ttf", "RecoletaBold");
                fonts.AddFont("Recoleta-Light.ttf", "RecoletaLight");
                fonts.AddFont("Recoleta-Medium.ttf", "RecoletaMedium");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<EmotionService>();
        builder.Services.AddSingleton<HomeView>();

        return builder.Build();
	}
}