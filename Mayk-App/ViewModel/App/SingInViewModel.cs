using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App;
using Org.BouncyCastle.Crypto.Generators;

namespace Mayk_App.ViewModel.App
{
    public partial class SingInViewModel : ObservableObject
    {
        private readonly IUserService _userService;
        public SingInViewModel(IUserService userService)
        {
            _userService = userService;
        }

        [RelayCommand]
        async Task RedirectToSingUp()
        {
            await Shell.Current.GoToAsync(nameof(SingUpPage));
        }

        [ObservableProperty]
        string userLogin;

        [ObservableProperty]
        string userPassword;

        [ObservableProperty]
        bool isWrong = false;

        [RelayCommand]
        async Task VerifyUser()
        {
            User user = await _userService.GetUserByEmail(UserLogin);
            if (user is not null)
            {
                if (user.Password.Equals(UserPassword))
                {
                    await Shell.Current.GoToAsync(nameof(MainPage), new Dictionary<string, object>
                    {
                        {"userId", user.UserId }
                    });
                }
            }
            IsWrong = true;
        }
    }
}
