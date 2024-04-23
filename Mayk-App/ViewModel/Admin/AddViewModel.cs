using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.ViewModel.Admin
{
    public partial class AddViewModel : ObservableObject
    {
        [RelayCommand]
        async Task RedirectToAddEventPage()
        {
            await Shell.Current.GoToAsync(nameof(AddEventPage));
        }

        [RelayCommand]
        async Task RedirectToAdRepetitionPage()
        {
            await Shell.Current.GoToAsync(nameof(AddRepetitionPage));
        }

    }
}
