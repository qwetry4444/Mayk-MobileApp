using Mayk_App.ViewModel;

namespace Mayk_App.View;

public partial class SingInPage : ContentPage
{
	public SingInPage(SingInViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}