using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View;

namespace Mayk_App.ViewModel
{
    public partial class SingUpViewModel : ObservableObject
    {
        private readonly IUserService _userService;

        public SingUpViewModel(IUserService userService)
        {
            _userService = userService;
        }

        [RelayCommand]
        async Task RedirectToSingIn()
        {
            await Shell.Current.GoToAsync(nameof(SingInPage));
        }

        [RelayCommand]
        async void VerifyUser()
        {
            if (string.IsNullOrEmpty(FirstName) 
                || string.IsNullOrEmpty(LastName) 
                || string.IsNullOrEmpty(Email) 
                || string.IsNullOrEmpty(PhoneNumber) 
                || string.IsNullOrEmpty(Password))
                return;
        }

        [RelayCommand]
        async Task RegisterUser()
        {

            User user = new User
            {
                UserId = _userId,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password,
                PhoneNumber = PhoneNumber,
                IsAdmin = false
            };
            await _userService.AddAsync(user);
            await Shell.Current.GoToAsync(nameof(MainPage), new Dictionary<string, object>
            {
                { "userId", user.UserId }
            });
        }

        int _userId = 0;

        [ObservableProperty]
        private string _firstName = "1";

        [ObservableProperty]
        private string _lastName = "1";

        [ObservableProperty]
        private string _phoneNumber = "1";

        [ObservableProperty]
        private string _email = "1";

        [ObservableProperty]
        private string _password = "1";

        [ObservableProperty]
        private string _passwordRepeat = "1";


    }
}
