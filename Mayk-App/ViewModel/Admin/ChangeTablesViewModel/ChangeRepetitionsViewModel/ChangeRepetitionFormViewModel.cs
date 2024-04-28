using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel
{

    [QueryProperty(nameof(RepetitionId), "repetitionId")]
    public partial class ChangeRepetitionFormViewModel : ObservableObject
    {
        public readonly IRepetitionService _repetitionService;
        public ChangeRepetitionFormViewModel(IRepetitionService repetitionService)
        {
            _repetitionService = repetitionService;
        }

        public Repetition? _repetition;

        [ObservableProperty]
        int repetitionId;

        [ObservableProperty]
        bool isUpdate = false;

        [ObservableProperty]
        bool isWrong = false;

        [ObservableProperty]
        int eventId;

        [ObservableProperty]
        string location;

        [ObservableProperty]
        DateTime date;

        [RelayCommand]
        async Task AddRepetition()
        {
            if (string.IsNullOrWhiteSpace(EventId.ToString()) ||
                string.IsNullOrWhiteSpace(Location) ||
                string.IsNullOrWhiteSpace(Date.ToString()))
            {
                IsWrong = true;
                return;
            }
            await _repetitionService.AddAsync(
                new Model.Repetition
                {
                    EventId = EventId,
                    Location = Location,
                    Date = Date
                });
            await Shell.Current.GoToAsync(nameof(RepetitionsListPage));
        }

        [RelayCommand]
        async Task UpdateRepetition()
        {
            await _repetitionService.UpdateAsync(new Repetition
            {
                EventId = EventId,
                Location = Location,
                Date = Date
            });
            await Shell.Current.GoToAsync(nameof(RepetitionsListPage));
        }

        [RelayCommand]
        public async Task FillEntrys()
        {
            _repetition = await _repetitionService.GetRepetitionById(RepetitionId);

            if (_repetition is not null)
            {
                IsUpdate = true;

                EventId = EventId;
                Location = Location;
                Date = Date;
            }
        }

        [RelayCommand]
        public async Task OnButtonClick()
        {
            if (IsUpdate)
            {
                await UpdateRepetition();
                return;
            }
            await AddRepetition();
        }
    }
}

