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
    public class RepetitionService : IRepetitionService
    {
        private SQLiteAsyncConnection connection;

        public RepetitionService()
        {
            SetupDatabase();
        }

        public async Task<int> AddAsync(Repetition repetition)
        {
            return await connection.InsertAsync(repetition);
        }

        public async Task<int> DeleteAsync(Repetition repetition)
        {
            return await connection.DeleteAsync(repetition);
        }

        public async Task<List<Repetition>> GetAsync()
        {
            return await connection.Table<Repetition>().ToListAsync();
        }

        public async Task<Repetition> GetUserRepetitions(string user_id)
        {
            var user = await connection.Table<User>()
                .Where(u => u.Email.ToLower().Equals(user_id.ToLower()))
                .FirstOrDefaultAsync();
            //var user = await connection.Table<User>()
            //    .FirstOrDefaultAsync();
            //return user;
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Repetition repetition)
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
            await connection.CreateTableAsync<Repetition>();
        }
    }
}
