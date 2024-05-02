using Mayk_App.View;

using Microsoft.Extensions.Logging;
using Mayk_App.Service;
using Mayk_App.View.Admin;

using Mayk_App.ViewModel.App;
using Mayk_App.ViewModel.Admin;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel;

using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeRepetitions;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsersRepetitions;

using Mayk_App.View.App;
using Mayk_App.ViewModel.App.Event;
using Mayk_App.View.App.Event;
using Mayk_App.ViewModel.App.Notes;
using Mayk_App.View.App.Note;

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
            mauiAppBuilder.Services.AddSingleton<INoteService, NoteService>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<StartViewModel>();
            mauiAppBuilder.Services.AddSingleton<SingInViewModel>();
            mauiAppBuilder.Services.AddSingleton<SingUpViewModel>();
            mauiAppBuilder.Services.AddSingleton<MainViewModel>();
            mauiAppBuilder.Services.AddSingleton<EventsScheduleViewModel>();

            mauiAppBuilder.Services.AddSingleton<EventDetailsViewModel>();
            mauiAppBuilder.Services.AddSingleton<EventDetailsViewModel>();
            mauiAppBuilder.Services.AddSingleton<EventDocumentsViewModel>();
            mauiAppBuilder.Services.AddSingleton<EventNotesViewModel>();

            mauiAppBuilder.Services.AddSingleton<NotesListViewModel>();
            mauiAppBuilder.Services.AddSingleton<NoteDetailsViewModel>();


            mauiAppBuilder.Services.AddSingleton<AddViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddEventViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddRepetitionViewModel>();
            mauiAppBuilder.Services.AddSingleton<UsersListViewModel>();

            mauiAppBuilder.Services.AddSingleton<TablesListViewModel>();

            mauiAppBuilder.Services.AddSingleton<UsersListViewModel>();
            mauiAppBuilder.Services.AddSingleton<UserChangeFormViewModel>();

            mauiAppBuilder.Services.AddSingleton<EventsListViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeEventsFormViewModel>();

            mauiAppBuilder.Services.AddSingleton<RepetitionsListViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeRepetitionFormViewModel>(); 
            
            mauiAppBuilder.Services.AddSingleton<UsersRepetitionsListViewModel>();
            mauiAppBuilder.Services.AddSingleton<ChangeUserRepetitionFormViewModel>();




            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<StartPage>();
            mauiAppBuilder.Services.AddTransient<View.App.SingUpPage>();
            mauiAppBuilder.Services.AddTransient<View.App.SingInPage>();
            mauiAppBuilder.Services.AddTransient<MainPage>();
            mauiAppBuilder.Services.AddTransient<EventsSchedulePage>();

            mauiAppBuilder.Services.AddTransient<EventDetailsPage>();
            mauiAppBuilder.Services.AddTransient<EventDocumentsPage>();
            mauiAppBuilder.Services.AddTransient<EventNotesPage>();

            mauiAppBuilder.Services.AddTransient<NotesListPage>();
            mauiAppBuilder.Services.AddTransient<NoteDetailsPage>();


            mauiAppBuilder.Services.AddTransient<AddPage>();
            mauiAppBuilder.Services.AddTransient<AddEventPage>();
            mauiAppBuilder.Services.AddTransient<AddRepetitionPage>();
            mauiAppBuilder.Services.AddTransient<UsersListPage>();

            mauiAppBuilder.Services.AddTransient<TablesListPage>();
            
            mauiAppBuilder.Services.AddTransient<UsersListPage>();
            mauiAppBuilder.Services.AddTransient<UserChangeForm>();

            mauiAppBuilder.Services.AddTransient<EventsListPage>();
            mauiAppBuilder.Services.AddTransient<ChangeEventForm>();

            mauiAppBuilder.Services.AddTransient<RepetitionsListPage>();
            mauiAppBuilder.Services.AddTransient<ChangeRepetitionForm>();

            mauiAppBuilder.Services.AddTransient<UsersRepetitionsListPage>();
            mauiAppBuilder.Services.AddTransient<ChangeUserRepetitionForm>();


            return mauiAppBuilder;
        }

    }
}
