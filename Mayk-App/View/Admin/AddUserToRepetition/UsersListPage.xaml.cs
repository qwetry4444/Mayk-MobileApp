using Mayk_App.ViewModel.Admin.AddUserToRepetitionViewModel;

namespace Mayk_App.View.Admin.AddUserToRepetition;


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

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}