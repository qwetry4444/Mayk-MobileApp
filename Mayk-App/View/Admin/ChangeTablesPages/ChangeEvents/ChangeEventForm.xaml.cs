using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;

public partial class ChangeEventForm : ContentPage
{
	private ChangeEventsFormViewModel viewModel;
	public ChangeEventForm(ChangeEventsFormViewModel vm)
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