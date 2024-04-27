using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;
using MvvmHelpers;


namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel
{
    public partial class ChangeEventsViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IEventService _eventService;

        public ObservableRangeCollection<Event> Events { get; set; }
        public ChangeEventsViewModel(IEventService eventService)
        {
            _eventService = eventService;
            Events = new();
        }

        public async Task LoadEvents()
        {
            Events.Clear();
            List<Event> events = await _eventService.GetAsync();
            Events.AddRange(Events);
        }

        public async Task DeleteUser(Event eventToDelete)
        {
            await _eventService.DeleteAsync(eventToDelete);
            await LoadEvents();
        }

        [RelayCommand]
        public async Task ChangeEvent(Event eventToDelete)
        {
            await Shell.Current.GoToAsync(nameof(ChangeEventForm), new Dictionary<string, object>
            {
                { "eventId", eventToDelete.EventId }
            });
        }

        [RelayCommand]
        public async Task RedirectToEventForm()
        {
            await Shell.Current.GoToAsync(nameof(ChangeEventForm));
        }
    }
}
