using Mayk_App.ViewModel.App;
namespace Mayk_App.View.App;

public partial class SingInPage : ContentPage
{
    public SingInPage(SingInViewModel vm)
	{

		InitializeComponent();
		BindingContext = vm;
	}
}