using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

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