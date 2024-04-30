using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;



namespace Mayk_App.ViewModel.App
{
    [QueryProperty(nameof(UserId), "userId")]
    public partial class MainViewModel : ObservableObject
    {
        private readonly IUserService _userService;
        private readonly IUserRepetitionService _userRepetitionService;
        private readonly IEventService _eventService;
        private readonly IRepetitionService _repetitionService;
        private readonly User user;

        public ObservableRangeCollection<Repetition> Repetitions { get; set; }

        public MainViewModel(
                IUserService userService, 
                IRepetitionService repetitionService, 
                IUserRepetitionService userRepetitionService, 
                IEventService eventService)
        {
            _userService = userService;
            _repetitionService = repetitionService;
            _userRepetitionService = userRepetitionService;
            _eventService = eventService;
        }


        [ObservableProperty]
        int userId;

        [ObservableProperty]
        User currentUser;

        [ObservableProperty]
        Event nearestEvent;

        [ObservableProperty]
        Repetition nearestRepetition;

        public async Task LoadNearestEvent()
        {
            NearestEvent = await _eventService.GetNearestEvent();
        }

        public async Task LoadNearestRepetition()
        {
            List<UserRepetition> userRepetitions = await _userRepetitionService.GetUserRepetitionsById(UserId);
            NearestRepetition = await _repetitionService.GetRepetitionById(1);
        }

        public async Task GetUser()
        {
            CurrentUser = await _userService.GetUserById(UserId);
        }


        [RelayCommand]
        async Task GetRepetition()
        {
            List<Repetition> repetitions = await _repetitionService.GetAsync();
            Repetitions.AddRange(repetitions);
        }

        [ObservableProperty]
        private string _userFirstName;
    }


}
