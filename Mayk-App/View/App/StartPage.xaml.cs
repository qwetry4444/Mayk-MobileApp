using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class StartPage : ContentPage
{
	public StartPage(StartViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
