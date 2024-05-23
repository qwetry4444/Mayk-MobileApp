using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class EventDocumentsPage : ContentPage
{
    private readonly EventDocumentsViewModel viewModel;
    public EventDocumentsPage(EventDocumentsViewModel vm)
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