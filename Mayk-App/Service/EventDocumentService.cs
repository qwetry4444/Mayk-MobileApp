
using Mayk_App.Model;
using SQLite;

namespace Mayk_App.Service
{
    public class DocumentEventService : IEventDocumentService
    {
        private SQLiteAsyncConnection connection;

        public DocumentEventService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(EventDocument eventDocument)
        {
            return await connection.InsertAsync(eventDocument);
        }

        public async Task<int> DeleteAsync(EventDocument eventDocument)
        {
            return await connection.DeleteAsync(eventDocument);
        }

        public async Task<List<EventDocument>> GetAsync()
        {
            return await connection.Table<EventDocument>().ToListAsync();
        }

        public async Task<EventDocument> GetByIdAsync(int id)
        {
            return await connection.Table<EventDocument>()
                .Where(ed => ed.DocumentEventId.Equals(id))
                .FirstOrDefaultAsync();
        }

        public async Task<List<int>> GetDocumentsIdByEvent(int eventId)
        {
            var eventDocs = await connection.Table<EventDocument>()
                .Where(ed => ed.EventId.Equals(eventId))
                .ToListAsync();
            List<int> x = new List<int>();
            foreach (EventDocument eventDoc in eventDocs)
            {
                x.Add(eventDoc.DocumentId);
            }
            return x;
        }

        public Task<int> UpdateAsync(EventDocument eventDocument)
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
            await connection.CreateTableAsync<EventDocument>();
        }
    }
}
