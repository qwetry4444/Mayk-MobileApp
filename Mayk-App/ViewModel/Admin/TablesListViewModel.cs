using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View.Admin.ChangeTablesPages;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;

namespace Mayk_App.ViewModel.Admin
{
    public partial class TablesListViewModel : ObservableObject
    {
        public TablesListViewModel() { }

        [RelayCommand]
        async Task RedirectToChangeUsersPage()
        {
            await Shell.Current.GoToAsync(nameof(ChangeUsersPage));
        }

        [RelayCommand]
        async Task RedirectToChangeEventsPage()
        {
            await Shell.Current.GoToAsync(nameof(ChangeEventsPage));
        }

        [RelayCommand]
        async Task RedirectToChangeRepetitionsPage()
        {
            await Shell.Current.GoToAsync(nameof(ChangeRepetitionsPage));
        }

        [RelayCommand]
        async Task RedirectToChangeUsersRepetitionsPage()
        {
            await Shell.Current.GoToAsync(nameof(ChangeUsersRepetitionsPage));
        }
    }
}

