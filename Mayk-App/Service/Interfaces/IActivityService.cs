using Mayk_App.Model;

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
