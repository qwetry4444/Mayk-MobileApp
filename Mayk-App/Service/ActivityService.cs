using Mayk_App.Model;
using SQLite;

namespace Mayk_App.Service
{
    public class ActivityService : IActivityService
    {
        private SQLiteAsyncConnection connection;

        public ActivityService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(Activity activity)
        {
            return await connection.InsertAsync(activity);
        }

        public async Task<int> DeleteAsync(Activity activity)
        {
            return await connection.DeleteAsync(activity);
        }

        public async Task<List<Activity>> GetAsync()
        {
            return await connection.Table<Activity>().ToListAsync();
        }


        public Task<int> UpdateAsync(Activity activity)
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
            await connection.CreateTableAsync<Activity>();
        }
    }
}


