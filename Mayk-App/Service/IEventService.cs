using Mayk_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public interface IEventService
    {
        Task<int> AddAsync(Event _event);
        Task<int> UpdateAsync(Event _event);
        Task<int> DeleteAsync(Event _event);


        Task<List<Event>> GetAsync();
        Task<Event> GetEventById(int eventId);

        Task<Event> GetUserEvents(string user_id);
        Task<List<Event>> GetFutherEvents();
        Task<Event> GetNearestEvent();
    }
}

