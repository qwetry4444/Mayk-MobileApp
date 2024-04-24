using Mayk_App.ViewModel.Admin;

namespace Mayk_App.View.Admin.AddUserToRepetition;

public partial class RepetitionsListPage : ContentPage
{
	private RepetitionsListViewModel viewModel;
	public RepetitionsListPage(RepetitionsListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        viewModel = vm;

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

		await viewModel.LoadRepetitions();
    }
}