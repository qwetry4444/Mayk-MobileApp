using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using Mayk_App.View.App.Note;
using MvvmHelpers;

namespace Mayk_App.ViewModel.App.Notes
{
    [QueryProperty(nameof(UserId), "userId")]
    public partial class NotesListViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly INoteService _noteService;
        public ObservableRangeCollection<Note> Notes { get; set; }

        public NotesListViewModel(INoteService noteService)
        {
            _noteService = noteService;
            Notes = new();
        }

        [ObservableProperty]
        int userId;

        [RelayCommand]
        public async Task LoadNotes()
        {
            Notes.Clear();
            List<Note> notes = await _noteService.GetUserNotes(UserId);
            Notes.AddRange(notes);
        }

        [RelayCommand]
        public async Task RedirectToNote(Note note)
        {
            await Shell.Current.GoToAsync(nameof(NoteDetailsPage), new Dictionary<string, object>
            {
                {"noteId",  note.NoteId },
                {"userId",  UserId }
            });
        }

        [RelayCommand]
        public async Task RedirectAddToNote()
        {
            await Shell.Current.GoToAsync(nameof(NoteDetailsPage), new Dictionary<string, object>
            {
                {"userId",  UserId }
            });
        }
    }
}
