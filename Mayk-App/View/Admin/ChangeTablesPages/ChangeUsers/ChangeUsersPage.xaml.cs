
/* �������������� ������� �� ������� "Mayk-App (net7.0-android)"
��:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
�����:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
*/

/* �������������� ������� �� ������� "Mayk-App (net7.0-maccatalyst)"
��:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
�����:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
*/

/* �������������� ������� �� ������� "Mayk-App (net7.0-windows10.0.19041.0)"
��:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
�����:
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
*/
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;
//using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel.ChangeUsersViewModel;

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