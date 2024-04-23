using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View;
using Mayk_App.View.Admin;

namespace Mayk_App.ViewModel
{
    public partial class StartViewModel : ObservableObject
    {
        [RelayCommand]
        async Task RedirectToSingUpPage()
        {
            await Shell.Current.GoToAsync(nameof(SingUpPage));
        }

        [RelayCommand]
        async Task RedirectToAddPage()
        {
            await Shell.Current.GoToAsync(nameof(AddPage));
        }
    }
}
