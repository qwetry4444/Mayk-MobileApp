
using Mayk_App.View;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.AddUserToRepetition;
using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

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
            Routing.RegisterRoute(nameof(RepetitionsListPage), typeof(RepetitionsListPage));
            Routing.RegisterRoute(nameof(UsersListPage), typeof(UsersListPage));

            Routing.RegisterRoute(nameof(TablesListPage), typeof(TablesListPage));

            Routing.RegisterRoute(nameof(ChangeUsersPage), typeof(ChangeUsersPage));
            Routing.RegisterRoute(nameof(UserChangeForm), typeof(UserChangeForm));

            Routing.RegisterRoute(nameof(ChangeRepetitionsPage), typeof(ChangeRepetitionsPage));
            Routing.RegisterRoute(nameof(ChangeEventsPage), typeof(ChangeEventsPage));
            Routing.RegisterRoute(nameof(ChangeUsersRepetitionsPage), typeof(ChangeUsersRepetitionsPage));


        }
    }
}
