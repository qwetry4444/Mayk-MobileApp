using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class EventNotesPage : ContentPage
{
    private readonly EventNotesViewModel viewModel;

    public EventNotesPage(EventNotesViewModel vm)
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