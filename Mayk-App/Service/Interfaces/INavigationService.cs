namespace Mayk_App.Service
{
    public interface INavigationService
    {
        Task NavigateToAsync(Page page);
        Task GoBackAsync(bool animated);
        Task InsertBeforeAndGoBack(Page page);
        Task InsertBeforeAndGoBack(String pageName);
    }
}