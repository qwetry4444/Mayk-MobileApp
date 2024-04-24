﻿
using Mayk_App.View;
using Mayk_App.View.Admin;
using Mayk_App.View.Admin.AddUserToRepetition;

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

        }
    }
}
