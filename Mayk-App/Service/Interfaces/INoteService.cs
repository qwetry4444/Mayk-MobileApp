using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface INoteService
    {
        Task<int> AddAsync(Note note);
        Task<int> UpdateAsync(Note note);
        Task<int> DeleteAsync(Note note);

        Task<List<Note>> GetUserNotes(int userId);
        Task<List<Note>> GetUserEventNotes(int userId, int eventId);

        Task<int> GetUserNotesCount(int userId);

        Task<List<Note>> GetAsync();
    }
}
