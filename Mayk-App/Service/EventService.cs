using Mayk_App.Model;
using SQLite;

namespace Mayk_App.Service
{
    public class EventService : IEventService
    {
        private SQLiteAsyncConnection connection;

        public EventService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(Event _event)
        {
            return await connection.InsertAsync(_event);
        }

        public async Task<int> DeleteAsync(Event _event)
        {
            return await connection.DeleteAsync(_event);
        }

        public async Task<List<Event>> GetAsync()
        {
            return await connection.Table<Event>().ToListAsync();
        }

        public async Task<Event> GetEventById(int eventId)
        {
            var _event = await connection.Table<Event>()
                .Where(u => u.EventId.Equals(eventId))
                .FirstOrDefaultAsync();
            return _event;
        }

        public async Task<int> UpdateAsync(Event _event)
        {
            return await connection.UpdateAsync(_event);
        }

        public async Task<List<Event>> GetFutherEvents()
        {
            return await connection.Table<Event>()
                .Where(e => e.Date > DateTime.Now)
                .OrderByDescending(e => e.Date)
                .ToListAsync();
        }


        public async Task<Event> GetNearestEvent()
        {
            return await connection.Table<Event>()
                .Where(u => DateTime.Now < u.Date)
                .OrderByDescending(u => u.Date)
                .FirstOrDefaultAsync();
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<Event>();
        }
    }
}
