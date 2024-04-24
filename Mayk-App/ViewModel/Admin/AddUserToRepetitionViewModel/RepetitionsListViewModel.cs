using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.AddUserToRepetition;
using MvvmHelpers;

namespace Mayk_App.ViewModel.Admin
{
    public partial class RepetitionsListViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IUserService UserService;
        private readonly IUserActivityService UserActivityService;
        private readonly IUserActivityRepetitionService UserActivityRepetitionService;
        private readonly IRepetitionService RepetitionService;

        public ObservableRangeCollection<User> Users { get; set; }
        public ObservableRangeCollection<Repetition> Repetitions { get; set; }
        public ObservableRangeCollection<UserActivityRepetition> UserActivityRepetitions { get; set; }

        public RepetitionsListViewModel(IUserService userService, 
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

        [RelayCommand]
        public async Task LoadRepetitions()
        {
            Repetitions.Clear();
            List<Repetition> repetitions = await RepetitionService.GetAsync();
            Repetitions.AddRange(repetitions);
        }

        [RelayCommand]
        async Task GoToUserList(Repetition repetition)
        {
            await Shell.Current.GoToAsync(nameof(UsersListPage), false, 
                new Dictionary<string, object>
                {
                    {"Repetition", repetition }
                });
        }

    }
}
