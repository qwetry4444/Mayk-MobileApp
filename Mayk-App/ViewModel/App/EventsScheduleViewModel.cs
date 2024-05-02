using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;

using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;


namespace Mayk_App.ViewModel.App
{
    [QueryProperty(nameof(UserId), "userId")]
    public partial class EventsScheduleViewModel : ObservableObject
    {
        private readonly IRepetitionService _repetitionService;
        private readonly IUserRepetitionService _userRepetitionService;
        private readonly IEventService _eventService;

        public ObservableRangeCollection<Model.Event> Events { get; set; }
        public ObservableRangeCollection<Repetition> Repetitions { get; set; }



        public EventsScheduleViewModel(
            IRepetitionService repetitionService, 
            IEventService eventService,
            IUserRepetitionService userRepetitionService)
        {
            Events = new();
            Repetitions = new();
            _repetitionService = repetitionService;
            _eventService = eventService;
            _userRepetitionService = userRepetitionService;
        }

        [ObservableProperty]
        int userId = 6;

        [ObservableProperty]
        ActivityType whatToDisplay = ActivityType.All;

        [RelayCommand]
        public async Task LoadEvents()
        {
            Events.Clear();
            List<Model.Event> events = await _eventService.GetFutherEvents();
            Events.AddRange(events);
        }

        [RelayCommand]
        public async Task LoadRepetitions()
        {
            Repetitions.Clear();
            List<UserRepetition> userRepetitions = await _userRepetitionService.GetFutherUserRepetitionsById(UserId);
            List<Repetition> repetitions = await _repetitionService.GetFutherUserRepetitionsById(userRepetitions);
            Repetitions.AddRange(repetitions);
        }
    }
    public enum ActivityType
    {
        Event = 0,
        Repetition = 1,
        All = 2
    }
}
