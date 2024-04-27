using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeUsers;

public partial class UserChangeForm : ContentPage
{
	private UserChangeFormViewModel viewModel;
	public UserChangeForm(UserChangeFormViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.FillEntrys();
    }
}