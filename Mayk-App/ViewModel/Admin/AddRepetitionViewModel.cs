using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;

namespace Mayk_App.ViewModel.Admin
{
    public partial class AddRepetitionViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly IRepetitionService RepetitionService;

        public ObservableRangeCollection<Repetition> Repetitions { get; set; }


        public AddRepetitionViewModel(IRepetitionService repetitionService)
        {
            RepetitionService = repetitionService;
            Repetitions = new();
        }

        [RelayCommand]
        async Task AddRepetition()
        {
            Repetition repetition = new Repetition
            {
                Date = Date,
                Location = Location,
                EventId = EventId
            };

            await RepetitionService.AddAsync(repetition);
        }

        [RelayCommand]
        async Task Refresh()
        {
            Repetitions.Clear();
            List<Repetition> repetitions = await RepetitionService.GetAsync();
            Repetitions.AddRange(repetitions);
        }


        [ObservableProperty]
        private string _eventId;

        [ObservableProperty]
        private DateTime _date;

        [ObservableProperty]
        private string _location;

    }
}
