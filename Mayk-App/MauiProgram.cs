using Mayk_App.View;
using Mayk_App.ViewModel;
using Microsoft.Extensions.Logging;
using CommunityToolkit;
using Mayk_App.Services;
using Mayk_App.Service;

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
            builder.Services.AddTransient<IUserService, UserService>();

            builder.Services.AddTransient<StartPage>();
            builder.Services.AddTransient<StartViewModel>();

            builder.Services.AddTransient<SingInPage>();
            builder.Services.AddTransient<SingInViewModel>();

            builder.Services.AddTransient<SingUpPage>();
            builder.Services.AddTransient<SingUpViewModel>();

            builder.Services.AddTransient<MainPage>();
            
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
