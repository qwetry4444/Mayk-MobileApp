
using Mayk_App.View;

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

        }
    }
}
