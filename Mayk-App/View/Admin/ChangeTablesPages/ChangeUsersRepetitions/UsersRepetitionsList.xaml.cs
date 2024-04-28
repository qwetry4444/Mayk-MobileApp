using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages;

public partial class UsersRepetitionsListPage : ContentPage
{
	public UsersRepetitionsListPage(UsersRepetitionsListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}