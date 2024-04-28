using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel
{
    [QueryProperty(nameof(UserId), "userId")]
    public partial class UserChangeFormViewModel : ObservableObject
    {
        public readonly IUserService _userService;
        public UserChangeFormViewModel(IUserService userService) 
        {
            _userService = userService; 
        }

        public User? user;

        [ObservableProperty]
        int userId;

        [ObservableProperty]
        bool isUpdate = false;

        [ObservableProperty]
        bool isWrong = false;

        [ObservableProperty]
        string firstName; 
        
        [ObservableProperty]
        string lastName; 
        
        [ObservableProperty]
        string email;

        [ObservableProperty]
        string phoneNumber;

        [ObservableProperty]
        string password;

        [RelayCommand]
        async Task AddUser()
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(PhoneNumber) ||
                string.IsNullOrWhiteSpace(Password))
            {
                IsWrong = true;
                return;
            }
            await _userService.AddAsync(
                new Model.User
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    PhoneNumber = PhoneNumber,
                    Password = Password
                });
            await Shell.Current.GoToAsync(nameof(UsersListPage));
        }

        [RelayCommand]
        async Task UpdateUser()
        {
            await _userService.UpdateAsync(new User
            {
                UserId = UserId,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Password = Password
            });
            await Shell.Current.GoToAsync(nameof(UsersListPage));
        }

        [RelayCommand]
        public async Task FillEntrys()
        {
            user = await _userService.GetUserById(UserId);

            if (user is not null)
            {
                IsUpdate = true;

                FirstName = user.FirstName;
                LastName = user.LastName;
                Email = user.Email;
                PhoneNumber = user.PhoneNumber;
                Password = user.Password;
            }
        }

        [RelayCommand]
        public async Task OnButtonClick()
        {
            if (IsUpdate)
            {
                await UpdateUser();
                return;
            }
            await AddUser();
        }
    }
}
