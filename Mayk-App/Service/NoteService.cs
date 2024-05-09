using Mayk_App.Model;
using SQLite;

namespace Mayk_App.Service
{
    public class NoteService : INoteService
    {
        private SQLiteAsyncConnection connection;

        public NoteService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(Note note)
        {
            return await connection.InsertAsync(note);
        }

        public async Task<int> DeleteAsync(Note note)
        {
            return await connection.DeleteAsync(note);
        }

        public async Task<List<Note>> GetAsync()
        {
            return await connection.Table<Note>().ToListAsync();
        }

        public Task<List<Note>> GetUserEventNotes(int userId, int eventId)
        {
            return connection.Table<Note>()
                .Where(n => n.UserId.Equals(userId) && n.EventId.Equals(eventId))
                .OrderBy(n => n.Date)
                .ToListAsync();
        }

        public async Task<List<Note>> GetUserNotes(int userId)
        {
            return await connection.Table<Note>()
                .Where(n => n.UserId.Equals(userId))
                .OrderByDescending(n => n.Date)
                .ToListAsync();
        }

        public async Task<int> GetUserNotesCount(int userId)
        {
            return await connection.Table<Note>()
                .Where(n => n.UserId.Equals(userId))
                .CountAsync();
        }



        public async Task<int> UpdateAsync(Note note)
        {
            return await connection.UpdateAsync(note);
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<Note>();
        }
    }
}
