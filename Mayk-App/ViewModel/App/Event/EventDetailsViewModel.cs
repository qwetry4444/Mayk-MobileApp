
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App.Event;

namespace Mayk_App.ViewModel.App.Event
{
    [QueryProperty(nameof(EventId), "eventId")]
    public partial class EventDetailsViewModel : ObservableObject
    {
        private readonly IEventService _eventService;

        public EventDetailsViewModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        Model.Event _event;
       

        public async Task LoadEvent() => _event = await _eventService.GetEventById(EventId);

        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            await Shell.Current.GoToAsync(nameof(EventDocumentsPage));
        }

        [RelayCommand]
        async Task RedirectToEventNotes()
        {
            await Shell.Current.GoToAsync(nameof(EventNotesPage));
        }
    }
}
