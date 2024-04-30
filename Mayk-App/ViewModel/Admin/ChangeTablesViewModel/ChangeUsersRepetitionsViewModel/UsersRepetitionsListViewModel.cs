using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeUsersRepetitions;
using MvvmHelpers;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel
{
    public partial class UsersRepetitionsListViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IUserRepetitionService _userRepetitionService;

        public ObservableRangeCollection<UserRepetition> UsersRepetitions { get; set; }
        public UsersRepetitionsListViewModel(IUserRepetitionService userRepetitionService)
        {
            _userRepetitionService = userRepetitionService;
            UsersRepetitions = new();
        }


        [RelayCommand]
        public async Task LoadUserRepetitions()
        {
            UsersRepetitions.Clear();
            List<UserRepetition> userRepetitions = await _userRepetitionService.GetAsync();
            UsersRepetitions.AddRange(userRepetitions);
        }


        [RelayCommand]
        public async Task DeleteUserRepetition(UserRepetition userRepetitionToDelete)
        {
            await _userRepetitionService.DeleteAsync(userRepetitionToDelete);
            await LoadUserRepetitions();
        }

        [RelayCommand]
        public async Task ChangeUserRepetition(UserRepetition UserRepetitionToDelete)
        {
            await Shell.Current.GoToAsync(nameof(ChangeUserRepetitionForm), new Dictionary<string, object>
            {
                { "UserRepetitionId", UserRepetitionToDelete.UserRepetitionId }
            });
        }

        [RelayCommand]
        public async Task RedirectToUserRepetitionForm()
        {
            await Shell.Current.GoToAsync(nameof(ChangeUserRepetitionForm));
        }
    }
}