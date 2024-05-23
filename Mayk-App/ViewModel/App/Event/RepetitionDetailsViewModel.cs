using Android.Media.Metrics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.ViewModel.App.Event
{
    [QueryProperty(nameof(RepetitionId), "repetitionId")]
    public partial class RepetitionDetailsViewModel : ObservableObject
    {
        private readonly IRepetitionService _repetitionService;
        private readonly IEventService _eventService;
        private readonly INavigationService _navigationService;


        public RepetitionDetailsViewModel(IRepetitionService repetitionService, INavigationService navigationService, IEventService eventService)
        {
            _repetitionService = repetitionService;
            _navigationService = navigationService;
            _eventService = eventService;
        }

        [ObservableProperty]
        int repetitionId;

        [ObservableProperty]
        Repetition repetition;

        [ObservableProperty]
        Model.Event repetitionEvent;

        public async Task LoadRepetition()
        {
            Repetition = await _repetitionService.GetRepetitionById(RepetitionId);
            RepetitionEvent = await _eventService.GetEventById(Repetition.EventId);
        }
    }
}