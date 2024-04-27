using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface IRepetitionService
    {
        Task<int> AddAsync(Repetition repetition);
        Task<int> UpdateAsync(Repetition repetition);
        Task<int> DeleteAsync(Repetition repetition);


        Task<List<Repetition>> GetAsync();
        Task<Repetition> GetRepetitionById(int repetitionId);

        Task<Repetition> GetUserRepetitions(string user_id);
    }
}
