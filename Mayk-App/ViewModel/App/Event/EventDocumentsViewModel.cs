using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        public EventDocumentsViewModel()
        {

        }






        [RelayCommand]
        async Task RedirectToEventDetails()
        {
            await Shell.Current.GoToAsync(nameof(EventDetailsPage));
        }

        [RelayCommand]
        async Task RedirectToEventNotes()
        {
            await Shell.Current.GoToAsync(nameof(EventNotesPage));
        }
    }
}
