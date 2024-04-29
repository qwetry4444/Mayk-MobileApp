
using Mayk_App.View.App;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeRepetitions;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsersRepetitions;

namespace Mayk_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SingInPage), typeof(SingInPage));
            Routing.RegisterRoute(nameof(SingUpPage), typeof(SingUpPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
            Routing.RegisterRoute(nameof(AddEventPage), typeof(AddEventPage));
            Routing.RegisterRoute(nameof(AddRepetitionPage), typeof(AddRepetitionPage));
            //Routing.RegisterRoute(nameof(RepetitionsListPage), typeof(RepetitionsListPage));
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
        }
    }
}
