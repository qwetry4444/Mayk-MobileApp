using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace Mayk_App.ViewModel.Admin
{
    public partial class AddEventViewModel : ObservableObject
    {
        private readonly IEventService EventService;

        public ObservableRangeCollection<Event> Events { get; set; }


        public AddEventViewModel(IEventService eventService)
        {
            EventService = eventService;
            Events = new();
        }

        [RelayCommand]
        async Task AddEvent()
        {
            Event _event = new Event
            {
                Name = Name,
                Date = Date,
                Location = Location,
                Description = Description
            };

            await EventService.AddAsync(_event);
        }

        [RelayCommand]
        async Task Refresh()
        {
            Events.Clear();
            List<Event> events = await EventService.GetAsync();
            Events.AddRange(events);
        }


        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private DateTime _date;

        [ObservableProperty]
        private string _location;

        [ObservableProperty]
        private string _description;
    }
}

