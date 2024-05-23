using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App;

namespace Mayk_App.ViewModel.App
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
            await Shell.Current.GoToAsync($"///MainTabBar/{nameof(MainPage)}", new Dictionary<string, object>
            {
                { "userId", user.UserId }
            });
        }

        int _userId = 0;

        [ObservableProperty]
        private string _firstName;

        [ObservableProperty]
        private string _lastName;

        [ObservableProperty]
        private string _phoneNumber;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _passwordRepeat;


    }
}
