using Mayk_App.ViewModel.Admin;

namespace Mayk_App.View.Admin;

public partial class AddEventPage : ContentPage
{
	public AddEventPage(AddEventViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}