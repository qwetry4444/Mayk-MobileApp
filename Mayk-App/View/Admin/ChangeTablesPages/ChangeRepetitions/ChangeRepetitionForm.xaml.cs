using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeRepetitions;

public partial class ChangeRepetitionForm : ContentPage
{
	private ChangeRepetitionFormViewModel viewModel;
    public ChangeRepetitionForm(ChangeRepetitionFormViewModel vm)
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