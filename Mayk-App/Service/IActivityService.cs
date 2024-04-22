using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface IActivityService
    {
        Task<int> AddAsync(Activity activity);
        Task<int> UpdateAsync(Activity activity);
        Task<int> DeleteAsync(Activity activity);


        Task<List<Activity>> GetAsync();
    }
}
