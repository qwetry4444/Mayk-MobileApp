using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class EventsSchedulePage : ContentPage
{
	private EventsScheduleViewModel viewModel;
	public EventsSchedulePage(EventsScheduleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.LoadEvents();
        await viewModel.LoadRepetitions();
    }
}