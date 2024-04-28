using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeUsersRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeUsersRepetitions;

public partial class ChangeUserRepetitionForm : ContentPage
{
	private ChangeUserRepetitionFormViewModel viewModel;
	public ChangeUserRepetitionForm(ChangeUserRepetitionFormViewModel vm)
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