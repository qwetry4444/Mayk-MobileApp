using Mayk_App.ViewModel;

namespace Mayk_App.View;

public partial class SingUpPage : ContentPage
{
	public SingUpPage(SingUpViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}