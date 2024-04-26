using Mayk_App.ViewModel.Admin;

namespace Mayk_App.View.Admin;

public partial class TablesListPage : ContentPage
{
	public TablesListPage(TablesListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}