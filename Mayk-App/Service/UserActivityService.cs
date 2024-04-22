using Mayk_App.Model;
using SQLite;

namespace Mayk_App.Service
{
    public class UserActivityService : IUserActivityService
    {
        private SQLiteAsyncConnection connection;

        public UserActivityService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(UserActivity userActivity)
        {
            return await connection.InsertAsync(userActivity);
        }

        public async Task<int> DeleteAsync(UserActivity userActivity)
        {
            return await connection?.DeleteAsync(userActivity);
        }

        public async Task<List<UserActivity>> GetAsync()
        {
            return await connection.Table<UserActivity>().ToListAsync();
        }

        public async Task<UserActivity> GetUserActivity(string email)
        {
            var user = await connection.Table<UserActivity>().FirstOrDefaultAsync();
            return user;
        }

        public async Task<int> UpdateAsync(UserActivity userActivity)
        {
            return await connection.UpdateAsync(userActivity);
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<UserActivity>();
        }
    }
}
