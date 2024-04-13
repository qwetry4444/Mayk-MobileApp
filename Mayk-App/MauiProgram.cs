using Mayk_App.View;
using Mayk_App.ViewModel;
using Microsoft.Extensions.Logging;

namespace Mayk_App
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

            builder.Services.AddSingleton<StartPage>();
            builder.Services.AddSingleton<StartViewModel>();

            builder.Services.AddTransient<SingInPage>();
            builder.Services.AddTransient<SingInViewModel>();

            builder.Services.AddTransient<SingUpPage>();
            builder.Services.AddTransient<SingUpViewModel>();

            builder.Services.AddSingleton<MainPage>();
            
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
