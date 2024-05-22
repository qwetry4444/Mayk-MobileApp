
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App;
using Mayk_App.View.App.Event;

namespace Mayk_App.ViewModel.App.Event
{
    [QueryProperty(nameof(EventId), "eventId")]
    public partial class EventDetailsViewModel : ObservableObject
    {
        private readonly IEventService _eventService;
        private readonly INavigationService _navigationService;
        private readonly EventDocumentsPage _eventDocumentsPage;
        private readonly EventNotesPage _eventNotesPage;

        public EventDetailsViewModel(IEventService eventService, INavigationService navigationService, EventDocumentsPage eventDocumentsPage, EventNotesPage eventNotesPage)
        {
            _eventService = eventService;
            _navigationService = navigationService;

            _eventDocumentsPage = eventDocumentsPage;
            _eventNotesPage = eventNotesPage;
        }

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        Model.Event _event;
       

        public async Task LoadEvent() => _event = await _eventService.GetEventById(EventId);

        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventDocumentsPage);
        }

        [RelayCommand]
        async Task RedirectToEventNotes()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventNotesPage);
        }
    }
}
