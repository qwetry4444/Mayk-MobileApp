
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

        private readonly EventDocumentsViewModel _eventDocumentsViewModel;
        private readonly EventNotesViewModel _eventNotesViewModel;

        public EventDetailsViewModel(IEventService eventService, INavigationService navigationService, EventDocumentsViewModel eventDocumentsViewModel, EventNotesViewModel eventNotesViewModel)
        {
            _eventService = eventService;
            _navigationService = navigationService;

            _eventDocumentsViewModel = eventDocumentsViewModel;
            _eventNotesViewModel = eventNotesViewModel;
        }

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        Model.Event _event;
       

        public async Task LoadEvent() => _event = await _eventService.GetEventById(EventId);

        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            //var navigation = Shell.Current.Navigation;
            //var currentPage = navigation.NavigationStack.LastOrDefault();

            //if (currentPage != null)
            //{
            //    navigation.RemovePage(currentPage);

            //    await Shell.Current.GoToAsync(nameof(EventDocumentsPage), new Dictionary<string, object>
            //    {
            //        {"eventId", EventId }
            //    });
            //}

            //await _navigationService.GoBackAsync(animated: false);
            var currentPage = Shell.Current.CurrentPage;
            await Shell.Current.GoToAsync(nameof(EventDocumentsPage), new Dictionary<string, object>
            {
                {"eventId", EventId }
            });
            Shell.Current.Navigation.RemovePage(currentPage);

            //await _navigationService.InsertBeforeAndGoBack(_eventDocumentsViewModel.);
        }

        [RelayCommand]
        async Task RedirectToEventNotes()
        {
            //await _navigationService.GoBackAsync(animated: false);

            var currentPage = Shell.Current.CurrentPage;
            await Shell.Current.GoToAsync(nameof(EventNotesPage), new Dictionary<string, object>
            {
                {"eventId", EventId }
            });
            Shell.Current.Navigation.RemovePage(currentPage);
            //await _navigationService.InsertBeforeAndGoBack(_eventNotesPage);
        }
    }
}
