using Mayk_App.Model;
using Microsoft.Maui.ApplicationModel.Communication;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public class UserRepetitionService : IUserRepetitionService
    {
        private SQLiteAsyncConnection connection;

        public UserRepetitionService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(UserRepetition userRepetition)
        {
            return await connection.InsertAsync(userRepetition);
        }

        public async Task<int> DeleteAsync(UserRepetition userRepetition)
        {
            return await connection.DeleteAsync(userRepetition);
        }

        public async Task<List<UserRepetition>> GetAsync()
        {
            return await connection.Table<UserRepetition>().ToListAsync();
        }

        public async Task<UserRepetition> GetUserRepetitionById(int userRepetitionId)
        {
            var userRepetition = await connection.Table<UserRepetition>()
                .Where(u => u.UserRepetitionId.Equals(userRepetitionId))
                .FirstOrDefaultAsync();
            return userRepetition;
        }

        public async Task<List<UserRepetition>> GetUserRepetition(string user_id)
        {
            var user = await connection.Table<UserRepetition>()
                .Where(u => u.UserId.Equals(user_id)).ToListAsync();
            return user;
        }

        public async Task<int> UpdateAsync(UserRepetition userRepetition)
        {
            return await connection.UpdateAsync(userRepetition);
        }

        private async void SetupDatabase()
        {
            if (connection is not null)
                return;

            string dbName = "MaykDatabase1.db3";
            string dbFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
            connection = new SQLiteAsyncConnection(dbFile);
            await connection.CreateTableAsync<UserRepetition>();
        }
    }
}
