using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeUser;

public partial class ChangeUsersPage : ContentPage
{
	private ChangeUsersViewModel viewModel;
	public ChangeUsersPage(ChangeUsersViewModel vm)
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