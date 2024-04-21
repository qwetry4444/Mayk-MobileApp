using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View;

namespace Mayk_App.ViewModel
{
    public partial class SingInViewModel : ObservableObject
    {

        [RelayCommand]
        async Task RedirectToSingUp()
        {
            await Shell.Current.GoToAsync(nameof(SingUpPage));
        }
    }
}
