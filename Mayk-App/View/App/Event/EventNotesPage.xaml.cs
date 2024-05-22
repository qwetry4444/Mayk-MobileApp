using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class EventNotesPage : ContentPage
{
	public EventNotesPage(EventNotesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}