using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.ViewModel
{
    public partial class StartViewModel : ObservableObject
    {
        [RelayCommand]
        async Task RedirectToCommand()
        {
            await Shell.Current.GoToAsync(nameof(SingInPage));
        }
    }
}
