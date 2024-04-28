
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel
{

    [QueryProperty(nameof(RepetitionId), "userRepetitionId")]
    public partial class ChangeUserRepetitionFormViewModel : ObservableObject
    {
        public readonly IUserRepetitionService _userRepetitionService;
        public ChangeUserRepetitionFormViewModel(IUserRepetitionService userRepetitionService)
        {
            _userRepetitionService = userRepetitionService;
        }

        public UserRepetition? _userRepetition;

        [ObservableProperty]
        int userRepetitionId;

        [ObservableProperty]
        bool isUpdate = false;

        [ObservableProperty]
        bool isWrong = false;

        [ObservableProperty]
        int userId;

        [ObservableProperty]
        int repetitionId;


        [RelayCommand]
        async Task AddUserRepetition()
        {
            if (string.IsNullOrWhiteSpace(RepetitionId.ToString()) ||
                string.IsNullOrWhiteSpace(UserId.ToString()))
            {
                IsWrong = true;
                return;
            }
            await _userRepetitionService.AddAsync(
                new Model.UserRepetition
                {
                    UserId = UserId,
                    RepetitionId = RepetitionId
                });
            await Shell.Current.GoToAsync(nameof(UsersRepetitionsListPage));
        }

        [RelayCommand]
        async Task UpdateUserRepetition()
        {
            await _userRepetitionService.UpdateAsync(new UserRepetition
            {
                UserId = UserId,
                RepetitionId = RepetitionId
            });
            await Shell.Current.GoToAsync(nameof(RepetitionsListPage));
        }

        [RelayCommand]
        public async Task FillEntrys()
        {
            _userRepetition = await _userRepetitionService.GetUserRepetitionById(UserRepetitionId);

            if (_userRepetition is not null)
            {
                IsUpdate = true;

                UserId = UserId;
                RepetitionId = RepetitionId;
            }
        }

        [RelayCommand]
        public async Task OnButtonClick()
        {
            if (IsUpdate)
            {
                await UpdateUserRepetition();
                return;
            }
            await AddUserRepetition();
        }
    }
}
