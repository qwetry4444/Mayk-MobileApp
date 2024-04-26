using Mayk_App.Model;
using Mayk_App.Service;
using SQLite;

namespace Mayk_App.Service
{
    public class UserService : IUserService
    {
        private SQLiteAsyncConnection connection;

        public UserService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(User user)
        {
            return await connection.InsertAsync(user);
        }

        public async Task<int> DeleteAsync(User user)
        {
            return await connection?.DeleteAsync(user);
        }

        public async Task<List<User>> GetAsync()
        {
            return await connection.Table<User>().ToListAsync(); 
        }

        public async Task<User> GetUser(string email)
        {
            var user = await connection.Table<User>()
                .Where(u => u.Email.ToLower().Equals(email.ToLower()))
                .FirstOrDefaultAsync();
            return user;
        }

        //public async Task<string> GetUserPasswordHash(string userId)
        //{
        //    string passwordHash = await connection.Table<User>()
        //        .Where(u => u.UserId.Equals(userId))
        //        .FirstOrDefaultAsync();
        //}

        public async Task<int> UpdateAsync(User user)
        {
            return await connection.UpdateAsync(user);
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<User>();
        }
    }
}