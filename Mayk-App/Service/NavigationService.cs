using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Service
{
    public class NavigationService : INavigationService
    {
        private readonly INavigation _navigation;

        public NavigationService(INavigation navigation)
        {
            _navigation = navigation;
        }

        public Task NavigateToAsync(Page page)
        {
            return _navigation.PushAsync(page);
        }

        public Task GoBackAsync(bool animated)
        {
            return _navigation.PopAsync(animated: animated);
            //_navigation.PopAsync(); 
        }

        public async Task InsertBeforeAndGoBack(Page page)
        {
            _navigation.InsertPageBefore(page, Shell.Current.CurrentPage);
            await _navigation.PopAsync(animated: true);
        }

        public async Task InsertBeforeAndGoBack(String pageName)
        {
            //_navigation.InsertPageBefore(Shell.Current.CurrentPage);
            await _navigation.PopAsync(animated: true);
        }

        public async Task ReplacePage()
        {

        }
    }
}
