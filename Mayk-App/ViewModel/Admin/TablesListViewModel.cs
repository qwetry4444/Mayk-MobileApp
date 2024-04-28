using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

namespace Mayk_App.ViewModel.Admin
{
    public partial class TablesListViewModel : ObservableObject
    {
        public TablesListViewModel() { }

        [RelayCommand]
        async Task RedirectToChangeUsersPage()
        {
            await Shell.Current.GoToAsync(nameof(UsersListPage));
        }

        [RelayCommand]
        async Task RedirectToChangeEventsPage()
        {
            await Shell.Current.GoToAsync(nameof(EventsListPage));
        }

        [RelayCommand]
        async Task RedirectToChangeRepetitionsPage()
        {
            await Shell.Current.GoToAsync(nameof(RepetitionsListPage));
        }

        [RelayCommand]
        async Task RedirectToChangeUsersRepetitionsPage()
        {
            await Shell.Current.GoToAsync(nameof(UsersRepetitionsListPage));
        }
    }
}

