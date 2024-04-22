using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface IUserActivityService
    {
        Task<int> AddAsync(UserActivity userActivity);
        Task<int> UpdateAsync(UserActivity userActivity);
        Task<int> DeleteAsync(UserActivity userActivity);


        Task<List<UserActivity>> GetAsync();
        Task<UserActivity> GetUserActivity(string user_id);
    }
}
