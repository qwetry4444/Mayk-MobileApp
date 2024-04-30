using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages;

public partial class UsersRepetitionsListPage : ContentPage
{
	private UsersRepetitionsListViewModel viewModel;
	public UsersRepetitionsListPage(UsersRepetitionsListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadUserRepetitions();
    }
}