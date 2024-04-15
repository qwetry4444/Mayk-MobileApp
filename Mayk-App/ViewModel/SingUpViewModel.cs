using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Service;
using Mayk_App.Services;
using Mayk_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.ViewModel
{
    public partial class SingUpViewModel : ObservableObject
    {
        private readonly IUserService userService;

        SingUpViewModel(IUserService userService)
        {
            this.userService = userService;
        }

        [RelayCommand]
        async Task RedirectToSingIn()
        {
            await Shell.Current.GoToAsync(nameof(SingInPage));
        }

        [RelayCommand]
        async void VerifyUser()
        {
            return;
        } 

        [ObservableProperty]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _passwordRepeat;
    }
}
