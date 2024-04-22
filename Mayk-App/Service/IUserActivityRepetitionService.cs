using Mayk_App.Model;

namespace Mayk_App.Service
{
    public interface IUserActivityRepetitionService
    {
        Task<int> AddAsync(UserActivityRepetition userActivityRepetition);
        Task<int> UpdateAsync(UserActivityRepetition userActivityRepetition);
        Task<int> DeleteAsync(UserActivityRepetition userActivityRepetition);


        Task<List<UserActivityRepetition>> GetAsync();
        Task<UserActivityRepetition> GetUserActivityRepetition(string user_id);
    }
}
