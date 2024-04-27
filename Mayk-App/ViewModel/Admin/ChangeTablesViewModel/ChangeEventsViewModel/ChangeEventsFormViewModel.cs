using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel
{
    [QueryProperty(nameof(EventId), "eventId")]
    public partial class ChangeEventsFormViewModel : ObservableObject
    {
        public readonly IEventService _eventService;
        public ChangeEventsFormViewModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        public Event? _event;

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        bool isUpdate = false;

        [ObservableProperty]
        bool isWrong = false;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        string location;

        [ObservableProperty]
        DateTime date;

        [RelayCommand]
        async Task AddEvent()
        {
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Description) ||
                string.IsNullOrWhiteSpace(Location) ||
                string.IsNullOrWhiteSpace(Date.ToString()))
            {
                IsWrong = true;
                return;
            }
            await _eventService.AddAsync(
                new Model.Event
                {
                    Name = Name,
                    Description = Description,
                    Location = Location,
                    Date = Date
                });
            await Shell.Current.GoToAsync(nameof(ChangeEventsPage));
        }

        [RelayCommand]
        async Task UpdateEvent()
        {
            await _eventService.UpdateAsync(new Event
            {
                Name = Name,
                Description = Description,
                Location = Location,
                Date = Date
            });
            await Shell.Current.GoToAsync(nameof(ChangeEventsPage));
        }

        [RelayCommand]
        public async Task FillEntrys()
        {
            _event = await _eventService.GetEventById(EventId);

            if (_event is not null)
            {
                IsUpdate = true;

                Name = _event.Name;
                Description = _event.Description;
                Location = _event.Location;
                Date = _event.Date;
            }
        }

        [RelayCommand]
        public async Task OnButtonClick()
        {
            if (IsUpdate)
            {
                await UpdateEvent();
                return;
            }
            await AddEvent();
        }
    }
}
