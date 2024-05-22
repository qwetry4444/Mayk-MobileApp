using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Service;
using Mayk_App.View.App.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.ViewModel.App.Event
{
    public partial class EventDocumentsViewModel : ObservableObject
    {

        private readonly IEventService _eventService;
        private readonly INavigationService _navigationService;

        private readonly EventDetailsPage _eventDetailsPage;
        private readonly EventNotesPage _eventNotesPage;

        public EventDocumentsViewModel(IEventService eventService, INavigationService navigationService, EventDetailsPage eventDetails, EventNotesPage eventNotesPage)
        {
            _eventService = eventService; 
            _navigationService = navigationService;
            
            _eventDetailsPage = eventDetails;
            _eventNotesPage = eventNotesPage;
        }



        [RelayCommand]
        async Task RedirectToEventDetails()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventDetailsPage);
        }

        [RelayCommand]
        async Task RedirectToEventNotes()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventNotesPage);
        }

    }
}
