using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.Admin.ChangeTablesPages.ChangeRepetitions;
using MvvmHelpers;

namespace Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel
{
    public partial class RepetitionsListViewModel : ObservableObject
    {
        private readonly IRepetitionService _repetitionService;

        public ObservableRangeCollection<Repetition> Repetitions { get; set; }
        public RepetitionsListViewModel(IRepetitionService repetitionService)
        {
            _repetitionService = repetitionService;
            Repetitions = new();
        }

        public async Task LoadRepetitions()
        {
            Repetitions.Clear();
            List<Repetition> repetitions = await _repetitionService.GetAsync();
            Repetitions.AddRange(repetitions);
        }

        public async Task DeleteRepetition(Repetition repetitionToDelete)
        {
            await _repetitionService.DeleteAsync(repetitionToDelete);
            await LoadRepetitions();
        }

        [RelayCommand]
        public async Task ChangeRepetition(Repetition repetitionToDelete)
        {
            await Shell.Current.GoToAsync(nameof(ChangeRepetitionForm), new Dictionary<string, object>
            {
                { "repetitionId", repetitionToDelete.RepetitionId }
            });
        }

        [RelayCommand]
        public async Task RedirectToRepetitionForm()
        {
            await Shell.Current.GoToAsync(nameof(ChangeRepetitionForm));
        }
    }
}

