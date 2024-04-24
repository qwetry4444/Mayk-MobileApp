using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;


namespace Mayk_App.ViewModel.Admin.AddUserToRepetitionViewModel
{
    public partial class UsersListViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IUserService UserService;
        private readonly IUserActivityService UserActivityService;
        private readonly IUserActivityRepetitionService UserActivityRepetitionService;
        private readonly IRepetitionService RepetitionService;
        private readonly IUserRepetitionService UserRepetitionService;

        public ObservableRangeCollection<User> Users { get; set; }
        public ObservableRangeCollection<UserActivityRepetition> UserActivityRepetitions { get; set; }

        public UsersListViewModel(IUserService userService,
            IUserActivityService userActivityService,
            IUserActivityRepetitionService userActivityRepetitionService,
            IRepetitionService repetitionService,
            IUserRepetitionService userRepetitionService)
        {
            UserService = userService;
            UserActivityService = userActivityService;
            UserActivityRepetitionService = userActivityRepetitionService;
            RepetitionService = repetitionService;
            UserRepetitionService = userRepetitionService;
            

            Users = new();
            UserActivityRepetitions = new();
        }

        [ObservableProperty]
        Repetition repetition;

        [RelayCommand]
        async Task AddUserToRepetition(User user)
        {
            await UserRepetitionService.AddAsync(
                new UserRepetition
                {
                    UsereId = user.UserId,
                    RepetitionId = repetition.RepetitionId
                });
        }

        [RelayCommand]
        public async Task LoadUsers()
        {
            Users.Clear();
            List<User> users = await UserService.GetAsync();
            Users.AddRange(users);
        }
    }
}
