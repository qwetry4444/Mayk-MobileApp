using Mayk_App.View;

using Microsoft.Extensions.Logging;
using Mayk_App.Service;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.AddUserToRepetition;

using Mayk_App.ViewModel;
using Mayk_App.ViewModel.Admin;
using Mayk_App.ViewModel.Admin.AddUserToRepetitionViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel;

using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;

/* Необъединенное слияние из проекта "Mayk-App (net7.0-android)"
До:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
После:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
*/

/* Необъединенное слияние из проекта "Mayk-App (net7.0-maccatalyst)"
До:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
После:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
*/

/* Необъединенное слияние из проекта "Mayk-App (net7.0-windows10.0.19041.0)"
До:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
После:
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
*/
//using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
//using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

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

            mauiAppBuilder.Services.AddSingleton<TablesListViewModel>();

            mauiAppBuilder.Services.AddSingleton<ChangeUsersViewModel>();
            mauiAppBuilder.Services.AddSingleton<UserChangeFormViewModel>();

            mauiAppBuilder.Services.AddSingleton<ChangeEventsViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeEventsFormViewModel>();



            mauiAppBuilder.Services.AddSingleton<ChangeEventsViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeRepetitionsViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeUsersRepetitionsViewModel>();



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

            mauiAppBuilder.Services.AddTransient<TablesListPage>();
            
            mauiAppBuilder.Services.AddTransient<ChangeUsersPage>();
            mauiAppBuilder.Services.AddTransient<UserChangeForm>();

            mauiAppBuilder.Services.AddTransient<ChangeEventsPage>();
            mauiAppBuilder.Services.AddTransient<ChangeRepetitionsPage>();
            mauiAppBuilder.Services.AddTransient<ChangeUsersRepetitionsPage>();


            return mauiAppBuilder;
        }

    }
}
