using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

public partial class UsersListPage : ContentPage
{
	private UsersListViewModel viewModel;
	public UsersListPage(UsersListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadUsers();
    }
}