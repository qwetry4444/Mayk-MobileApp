using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Service;
using Mayk_App.View.App.Event;
using Microsoft.Extensions.Logging;

namespace Mayk_App.ViewModel.App.Event
{
    [QueryProperty(nameof(EventId), "eventId")]
    public partial class EventNotesViewModel : ObservableObject
    {
        private readonly IEventService _eventService;
        private readonly INavigationService _navigationService;

        private readonly EventDetailsPage _eventDetailsPage;
        private readonly EventDocumentsPage _eventDocumentsPage;

        public EventNotesViewModel(IEventService eventService, INavigationService navigationService)
        {
            _eventService = eventService;
            _navigationService = navigationService;
        }

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        Model.Event _event;


        public async Task LoadEvent() => _event = await _eventService.GetEventById(EventId);

        [RelayCommand]
        async Task RedirectToEventDetails()
        {
            var currentPage = Shell.Current.CurrentPage;
            await Shell.Current.GoToAsync(nameof(EventDetailsPage), new Dictionary<string, object>
            {
                {"eventId", EventId }
            });
            Shell.Current.Navigation.RemovePage(currentPage);

            //await _navigationService.GoBackAsync(animated: false);
            //await _navigationService.InsertBeforeAndGoBack(_eventDetailsPage);
        }


        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            //await _navigationService.GoBackAsync(animated: false);

            var currentPage = Shell.Current.CurrentPage;
            await Shell.Current.GoToAsync(nameof(EventDocumentsPage), new Dictionary<string, object>
            {
                {"eventId", EventId }
            });
            Shell.Current.Navigation.RemovePage(currentPage);

            //await _navigationService.InsertBeforeAndGoBack(_eventDocumentsPage);

        }
    }
}
