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

        public async Task<Repetition> GetRepetitionById(int repetitionId)
        {
            var repetition = await connection.Table<Repetition>()
                .Where(u => u.RepetitionId.Equals(repetitionId))
                .FirstOrDefaultAsync();
            return repetition;
        }

        public async Task<Repetition> GetUserRepetitions(int user_id)
        {
            var user = await connection.Table<User>()
                .Where(u => u.UserId.Equals(user_id))
                .FirstOrDefaultAsync();
            //var user = await connection.Table<User>()
            //    .FirstOrDefaultAsync();
            //return user;
            throw new NotImplementedException();
        }

        public async Task<List<Repetition>> GetFutherUserRepetitionsById(List<UserRepetition> userRepetitions)
        {
            List<int> repetitionsIds = userRepetitions.Select(ur => ur.RepetitionId).ToList();
            DateTime now = DateTime.Now;
            List<Repetition> futherRepetitions = await connection.Table<Repetition>()
                .Where(repetition => repetitionsIds.Contains(repetition.RepetitionId) && repetition.Date > now)
                .ToListAsync();
            return futherRepetitions;   
        }

        public Task<Repetition> GetNearestUserRepetition(int userId)
        {
            return null;
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
