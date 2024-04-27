using Mayk_App.ViewModel;

namespace Mayk_App.View;

public partial class EventsSchedulePage : ContentPage
{
	public EventsSchedulePage(EventsScheduleViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}