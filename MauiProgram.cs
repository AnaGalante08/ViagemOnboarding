using Microsoft.Extensions.Logging;
using ViagemOnboarding.ViewModel;
using ViagemOnboarding.Views;

namespace ViagemOnboarding
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Logging.AddDebug();
            builder.Services.AddSingleton<OnboardingViewModel>();
            builder.Services.AddSingleton<OnboardingPage>();

#endif

            return builder.Build();
        }
    }
}
