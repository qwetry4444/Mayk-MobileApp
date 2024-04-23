using Mayk_App.ViewModel.Admin;

namespace Mayk_App.View.Admin;

public partial class AddPage : ContentPage
{
	public AddPage(AddViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}