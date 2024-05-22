using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class EventDocumentsPage : ContentPage
{

    public EventDocumentsPage(EventDocumentsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}