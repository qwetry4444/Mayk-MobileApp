using Mayk_App.Model;
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

        Task<int> IRepetitionService.AddAsync(Repetition repetition)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepetitionService.DeleteAsync(Repetition repetition)
        {
            throw new NotImplementedException();
        }

        async Task<List<Repetition>> IRepetitionService.GetAsync()
        {
            return await connection.Table<Repetition>().ToListAsync();
        }

        Task<Repetition> IRepetitionService.GetUserRepetition(string user_id)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepetitionService.UpdateAsync(Repetition repetition)
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
