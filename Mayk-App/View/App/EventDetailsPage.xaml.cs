using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class EventDetailsPage : ContentPage
{
	public EventDetailsPage(EventDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}