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
    public partial class EventNotesViewModel : ObservableObject
    {

        public EventNotesViewModel() 
        { 

        }



        [RelayCommand]
        async Task RedirectToEventDetails()
        {
            await Shell.Current.GoToAsync(nameof(EventDetailsPage));
        }


        [RelayCommand]
        async Task RedirectToEventDocuments()
        {
            await Shell.Current.GoToAsync(nameof(EventDocumentsPage));
        }
    }
}
