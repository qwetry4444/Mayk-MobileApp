
using Mayk_App.Model;

namespace Mayk_App.Service
{
    public interface IEventDocumentService
    {
        Task<int> AddAsync(EventDocument eventDocument);
        Task<int> UpdateAsync(EventDocument eventDocument);
        Task<int> DeleteAsync(EventDocument eventDocument);

        Task<EventDocument> GetByIdAsync(int id);

        Task<List<int>> GetDocumentsIdByEvent(int eventId);

        Task<List<EventDocument>> GetAsync();
    }
}
