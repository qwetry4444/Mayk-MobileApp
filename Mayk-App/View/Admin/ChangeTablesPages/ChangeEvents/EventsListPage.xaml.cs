using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeEvents;

public partial class EventsListPage : ContentPage
{
	private EventsListViewModel viewModel;
	public EventsListPage(EventsListViewModel vm)
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