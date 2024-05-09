using Mayk_App.Model;
using SQLite;


namespace Mayk_App.Service
{
    public class DocumentService : IDocumentService
    {
        private SQLiteAsyncConnection connection;

        public DocumentService()
        {
            SetupDatabase();
        }


        public async Task<int> AddAsync(Document document)
        {
            return await connection.InsertAsync(document);
        }

        public async Task<int> DeleteAsync(Document document)
        {
            return await connection.DeleteAsync(document);

        }

        public async Task<List<Document>> GetAsync()
        {
            return await connection.Table<Document>().ToListAsync();
        }

        public async Task<int> UpdateAsync(Document document)
        {
            return await connection.UpdateAsync(document);
        }

        public async Task<Document> GetByIdAsync(int id)
        {
            return await connection.Table<Document>()
                .Where(d => d.DocumentId.Equals(id))
                .FirstOrDefaultAsync();
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<Document>();
        }
    }
}
