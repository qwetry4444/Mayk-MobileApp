using Mayk_App.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public class EventService : IEventService
    {
        private SQLiteAsyncConnection connection;

        public EventService()
        {
            SetupDatabase();
        }

        public Task<int> AddAsync(Event _event)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Event _event)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Event>> GetAsync()
        {
            return await connection.Table<Event>().ToListAsync();
        }

        public Task<Event> GetUserEvents(string user_id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Event _event)
        {
            throw new NotImplementedException();
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
