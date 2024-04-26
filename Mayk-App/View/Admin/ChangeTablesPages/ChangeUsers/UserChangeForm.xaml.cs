using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

public partial class UserChangeForm : ContentPage
{

	public UserChangeForm(UserChangeFormViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}