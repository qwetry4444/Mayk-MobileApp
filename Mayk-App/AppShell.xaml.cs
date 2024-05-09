
using Mayk_App.View.App;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeRepetitions;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsersRepetitions;
using Mayk_App.View.App.Event;
using Mayk_App.View.App.Note;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEventDocuments;

namespace Mayk_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(SingInPage), typeof(SingInPage));
            Routing.RegisterRoute(nameof(SingUpPage), typeof(SingUpPage));
            //Routing.RegisterRoute($"///MainTabBar", typeof(MainPage));
            //Routing.RegisterRoute($"///MainTabBar/{nameof(MainPage)}", typeof(MainPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(EventsSchedulePage), typeof(EventsSchedulePage));

            //Routing.RegisterRoute($"///MainTabBar/EventTabBar/{nameof(EventDetailsPage)}", typeof(EventDetailsPage));
            //Routing.RegisterRoute($"///MainTabBar/EventTabBar", typeof(EventDetailsPage));

            //Routing.RegisterRoute($"///EventTabBar/{nameof(EventDetailsPage)}", typeof(EventDetailsPage));
            //Routing.RegisterRoute($"///EventTabBar", typeof(EventDetailsPage));

            //Routing.RegisterRoute($"EventTabBar", typeof(EventDetailsPage));

            //Routing.RegisterRoute($"///EventTabBar/{nameof(EventDetailsPage)}", typeof(EventDetailsPage));
            //Routing.RegisterRoute(nameof(EventDetailsPage), typeof(EventDetailsPage));

            //Routing.RegisterRoute($"///EventTabBar/{nameof(EventDocumentsPage)}", typeof(EventDocumentsPage));
            //Routing.RegisterRoute($"///EventTabBar/{nameof(EventNotesPage)}", typeof(EventNotesPage));
            
            Routing.RegisterRoute(nameof(EventDetailsPage), typeof(EventDetailsPage));
            Routing.RegisterRoute(nameof(EventDocumentsPage), typeof(EventDocumentsPage));
            Routing.RegisterRoute(nameof(EventNotesPage), typeof(EventNotesPage));

            Routing.RegisterRoute(nameof(NotesListPage), typeof(NotesListPage));
            Routing.RegisterRoute(nameof(NoteDetailsPage), typeof(NoteDetailsPage));


            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
            Routing.RegisterRoute(nameof(AddEventPage), typeof(AddEventPage));
            Routing.RegisterRoute(nameof(AddRepetitionPage), typeof(AddRepetitionPage));
            Routing.RegisterRoute(nameof(UsersListPage), typeof(UsersListPage));




            Routing.RegisterRoute(nameof(TablesListPage), typeof(TablesListPage));

            Routing.RegisterRoute(nameof(UsersListPage), typeof(UsersListPage));
            Routing.RegisterRoute(nameof(UserChangeForm), typeof(UserChangeForm));

            Routing.RegisterRoute(nameof(EventsListPage), typeof(EventsListPage));
            Routing.RegisterRoute(nameof(ChangeEventForm), typeof(ChangeEventForm));

            Routing.RegisterRoute(nameof(UsersRepetitionsListPage), typeof(UsersRepetitionsListPage));
            Routing.RegisterRoute(nameof(ChangeUserRepetitionForm), typeof(ChangeUserRepetitionForm));

            Routing.RegisterRoute(nameof(RepetitionsListPage), typeof(RepetitionsListPage));
            Routing.RegisterRoute(nameof(ChangeRepetitionForm), typeof(ChangeRepetitionForm));

            Routing.RegisterRoute(nameof(ChangeEventDocumentForm), typeof(ChangeEventDocumentForm));

        }
    }
}
