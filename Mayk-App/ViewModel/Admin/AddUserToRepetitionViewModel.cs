using CommunityToolkit.Mvvm.ComponentModel;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.Services;
using MvvmHelpers;

namespace Mayk_App.ViewModel.Admin
{
    public partial class AddUserToRepetitionViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IUserService UserService;
        private readonly IUserActivityService UserActivityService;
        private readonly IUserActivityRepetitionService UserActivityRepetitionService;
        private readonly IRepetitionService RepetitionService;

        public ObservableRangeCollection<User> Users;
        public ObservableRangeCollection<Repetition> Repetitions;
        public ObservableRangeCollection<UserActivityRepetition> UserActivityRepetitions;

        public AddUserToRepetitionViewModel(IUserService userService, 
            IUserActivityService userActivityService, 
            IUserActivityRepetitionService userActivityRepetitionService,
            IRepetitionService repetitionService)
        {
            UserService = userService;
            UserActivityService = userActivityService;
            UserActivityRepetitionService = userActivityRepetitionService;
            RepetitionService = repetitionService;

            Users = new();
            Repetitions = new();
            UserActivityRepetitions = new();
        }

    }
}
