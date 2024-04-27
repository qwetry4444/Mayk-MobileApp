using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;

public partial class ChangeEventsPage : ContentPage
{
	private ChangeEventsViewModel viewModel;
	public ChangeEventsPage(ChangeEventsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadEvents();
    }
}