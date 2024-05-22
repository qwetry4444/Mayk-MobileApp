namespace Mayk_App.Service
{
    public interface INavigationService
    {
        Task NavigateToAsync(Page page);
        Task GoBackAsync();
        Task InsertBeforeAndGoBack(Page page);
    }
}