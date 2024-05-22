
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Service;

namespace Mayk_App.ViewModel.App.Notes
{
    [QueryProperty(nameof(NoteId), "noteId")]
    [QueryProperty(nameof(UserId), "userId")]
    public partial class NoteDetailsViewModel : ObservableObject
    {
        private readonly INoteService _noteService;

        public NoteDetailsViewModel(INoteService noteService)
        {
            _noteService = noteService;
        }


        [ObservableProperty]
        int noteId;
        [ObservableProperty]
        int userId;

        [ObservableProperty]
        string noteTitle;
        [ObservableProperty]
        string noteDescription;


        [RelayCommand]
        public async Task LoadOrCreateNote()
        {
            if (NoteId == 0)
            {
                int userNotesCount = await _noteService.GetUserNotesCount(UserId);
                await _noteService.AddAsync(new Model.Note
                {
                    UserId = UserId,
                    Date = DateTime.Now,
                    Title = $"Заметка {userNotesCount + 1}",
                    Description = "",
                });
            }
            else
            {
                await _noteService.UpdateAsync(new Model.Note
                {
                    NoteId = NoteId,
                    Title = NoteTitle,
                    Description = NoteDescription
                });
            }
        }

    }
}
