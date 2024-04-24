using Mayk_App.View;
using Mayk_App.ViewModel;
using Microsoft.Extensions.Logging;
using Mayk_App.Service;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.AddUserToRepetition;
using Mayk_App.ViewModel.Admin;
using Mayk_App.ViewModel.Admin.AddUserToRepetitionViewModel;

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
                    fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                    fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                    fonts.AddFont("Montserrat-Semibold.ttf", "MontserratSemibold");
                })
                .RegisterAppServices()
                .RegisterViewModels()
                .RegisterViews();
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif
            });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IUserService, UserService>();
            mauiAppBuilder.Services.AddSingleton<IActivityService, ActivityService>();
            mauiAppBuilder.Services.AddSingleton<IUserActivityService, UserActivityService>();

            mauiAppBuilder.Services.AddSingleton<IEventService, EventService>();
            mauiAppBuilder.Services.AddSingleton<IRepetitionService, RepetitionService>();
            mauiAppBuilder.Services.AddSingleton<IUserActivityRepetitionService, UserActivityRepetitionService>();
            mauiAppBuilder.Services.AddSingleton<IUserRepetitionService, UserRepetitionService>();


            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<StartViewModel>();
            mauiAppBuilder.Services.AddSingleton<SingInViewModel>();
            mauiAppBuilder.Services.AddSingleton<SingUpViewModel>();
            mauiAppBuilder.Services.AddSingleton<MainViewModel>();
            mauiAppBuilder.Services.AddSingleton<EventsScheduleViewModel>();

            mauiAppBuilder.Services.AddSingleton<AddViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddEventViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddRepetitionViewModel>();
            mauiAppBuilder.Services.AddSingleton<RepetitionsListViewModel>();
            mauiAppBuilder.Services.AddSingleton<UsersListViewModel>();


            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<StartPage>();
            mauiAppBuilder.Services.AddTransient<SingUpPage>();
            mauiAppBuilder.Services.AddTransient<SingInPage>();
            mauiAppBuilder.Services.AddTransient<MainPage>();
            mauiAppBuilder.Services.AddTransient<EventsSchedulePage>();



            mauiAppBuilder.Services.AddTransient<AddPage>();
            mauiAppBuilder.Services.AddTransient<AddEventPage>();
            mauiAppBuilder.Services.AddTransient<AddRepetitionPage>();
            mauiAppBuilder.Services.AddTransient<RepetitionsListPage>();
            mauiAppBuilder.Services.AddTransient<UsersListPage>();

            return mauiAppBuilder;
        }

    }
}
