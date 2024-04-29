using CommunityToolkit.Mvvm.ComponentModel;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;

using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;


namespace Mayk_App.ViewModel.App
{
    public partial class EventsScheduleViewModel : ObservableObject
    {
        private readonly IRepetitionService RepetitionService;
        
        private readonly IEventService EventService;

        public ObservableRangeCollection<Event> Events { get; set; }
        public ObservableRangeCollection<Repetition> Repetitions { get; set; }



        public EventsScheduleViewModel(RepetitionService repetitionService, EventService eventService)
        {
            Events = new();
            Repetitions = new();
            RepetitionService = repetitionService;
            EventService = eventService;
        }

    }
}
