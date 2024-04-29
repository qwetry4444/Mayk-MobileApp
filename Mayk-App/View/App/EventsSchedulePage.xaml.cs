using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class EventsSchedulePage : ContentPage
{
	public EventsSchedulePage(EventsScheduleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}