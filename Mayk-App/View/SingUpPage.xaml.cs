using Mayk_App.ViewModel;

namespace Mayk_App.View;

public partial class SingUpPage : ContentPage
{
	private readonly SingUpViewModel singUpViewModel;
	public SingUpPage(SingUpViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		singUpViewModel = vm;
	}
}