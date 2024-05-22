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
    public partial class EventNotesViewModel : ObservableObject
    {
        private readonly IEventService _eventService;
        private readonly INavigationService _navigationService;

        private readonly EventDetailsPage _eventDetailsPage;
        private readonly EventDocumentsPage _eventDocumentsPage;

        public EventNotesViewModel(IEventService eventService, INavigationService navigationService, EventDetailsPage eventDetailsPage, EventDocumentsPage eventDocumentsPage)
        {
            _eventService = eventService;
            _navigationService = navigationService;
            
            _eventDetailsPage = eventDetailsPage;
            _eventDocumentsPage = eventDocumentsPage;
        }



        [RelayCommand]
        async Task RedirectToEventDetails()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventDetailsPage);
        }


        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            await _navigationService.InsertBeforeAndGoBack(_eventDocumentsPage);

        }
    }
}
