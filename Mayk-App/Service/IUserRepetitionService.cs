using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface IUserRepetitionService
    {
        Task<int> AddAsync(UserRepetition userRepetition);
        Task<int> UpdateAsync(UserRepetition userRepetition);
        Task<int> DeleteAsync(UserRepetition userRepetition);

        Task<UserRepetition> GetUserRepetitionById(int userRepetiionId);

        Task<List<UserRepetition>> GetAsync();
    }
}
