using Mayk_App.Model;

namespace Mayk_App.Service
{
    public interface IDocumentService
    {
        Task<int> AddAsync(Document document);
        Task<int> UpdateAsync(Document document);
        Task<int> DeleteAsync(Document document);

        Task<Document> GetByIdAsync(int id);

        Task<List<Document>> GetAsync();
    }
}
