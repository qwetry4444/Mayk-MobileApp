using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View.App;
using Mayk_App.View.Admin;

namespace Mayk_App.ViewModel.App
{
    public partial class StartViewModel : ObservableObject
    {
        [RelayCommand]
        async Task RedirectToSingUpPage()
        {
            await Shell.Current.GoToAsync(nameof(SingUpPage));
        }

        [RelayCommand]
        async Task RedirectToTablesListPage()
        {
            await Shell.Current.GoToAsync(nameof(TablesListPage));
        }
    }
}
