using Mayk_App.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public class UserActivityRepetitionService : IUserActivityRepetitionService
    {
        private SQLiteAsyncConnection connection;

        public UserActivityRepetitionService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(UserActivityRepetition userActivityRepetition)
        {
            return await connection.InsertAsync(userActivityRepetition);
        }

        public async Task<int> DeleteAsync(UserActivityRepetition userActivityRepetition)
        {
            return await connection.DeleteAsync(userActivityRepetition);
        }

        public async Task<List<UserActivityRepetition>> GetAsync()
        {
            return await connection.Table<UserActivityRepetition>().ToListAsync();
        }

        public Task<UserActivityRepetition> GetUserActivityRepetition(string user_id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(UserActivityRepetition userActivityRepetition)
        {
            return await connection.UpdateAsync(userActivityRepetition);
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<UserActivityRepetition>();
        }
    }
}
