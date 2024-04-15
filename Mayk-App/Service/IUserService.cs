using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Services
{
    public interface IUserService
    {
        Task<int> AddAsync(User user);
        Task<int> UpdateAsync(User user);
        Task<int> DeleteAsync(User user);


        Task<List<User>> GetAsync();
        Task<User> GetUser(string email);
    }
}
