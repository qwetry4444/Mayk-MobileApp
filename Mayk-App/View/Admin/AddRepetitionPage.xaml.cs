using Mayk_App.ViewModel.Admin;

namespace Mayk_App.View.Admin;

public partial class AddRepetitionPage : ContentPage
{
	public AddRepetitionPage(AddRepetitionViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}