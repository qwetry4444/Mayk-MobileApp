﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;
using MvvmHelpers;


namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel
{
    public partial class UsersListViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IUserService _userService;

        public ObservableRangeCollection<User> Users { get; set; }
        public UsersListViewModel(IUserService userService)
        {
            _userService = userService;
            Users = new();
        }

        public async Task LoadUsers()
        {
            Users.Clear();
            List<User> users = await _userService.GetAsync();
            Users.AddRange(users);
        }

        public async Task DeleteUser(User userToDelete)
        {
            await _userService.DeleteAsync(userToDelete);
            await LoadUsers();
        }

        [RelayCommand]
        public async Task ChangeUser(User userToDelete)
        {
            await Shell.Current.GoToAsync(nameof(UserChangeForm), new Dictionary<string, object>
            {
                { "userId", userToDelete.UserId }
            });
        }

        [RelayCommand]
        public async Task RedirectToUserForm()
        {
            await Shell.Current.GoToAsync(nameof(UserChangeForm));
        }
    }
}