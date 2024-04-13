using Mayk_App.ViewModel;

namespace Mayk_App;

public partial class StartPage : ContentPage
{
	public StartPage(StartViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}