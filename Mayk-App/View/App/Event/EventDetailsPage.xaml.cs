using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class EventDetailsPage : ContentPage
{
	private readonly EventDetailsViewModel viewModel;
	public EventDetailsPage(EventDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadEvent();
    }
}