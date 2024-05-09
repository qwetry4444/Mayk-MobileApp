using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App.Event;
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
        int userId = 6;

        [ObservableProperty]
        User currentUser;

        [ObservableProperty]
        string _userFirstName;

        [ObservableProperty]
        Model.Event nearestEvent;

        [ObservableProperty]
        Repetition nearestRepetition;

        public async Task LoadNearestEvent()
        {
            NearestEvent = await _eventService.GetNearestEvent();
        }

        public async Task LoadNearestRepetition()
        {
            List<UserRepetition> userRepetitions = await _userRepetitionService.GetFutherUserRepetitionsById(UserId);
            List<Repetition> repetitions = await _repetitionService.GetFutherUserRepetitionsById(userRepetitions);
            
            NearestRepetition = repetitions.FirstOrDefault();
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

        [RelayCommand]
        async Task RedirectToEvent()
        {
            var x = Shell.Current.Navigation.NavigationStack;

            await Shell.Current.GoToAsync(nameof(EventDetailsPage), new Dictionary<string, object>
            {
                {"eventId", NearestEvent.EventId }
            });
        }

        [RelayCommand]
        async Task RedirectToRepetition()
        {
            await Shell.Current.GoToAsync(nameof(EventDetailsPage), new Dictionary<string, object>
            {
                {"eventId", NearestRepetition.RepetitionId}
            });
        }
    }
}