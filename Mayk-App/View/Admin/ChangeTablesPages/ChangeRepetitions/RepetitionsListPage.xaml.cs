using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages;

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