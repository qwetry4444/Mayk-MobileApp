using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeRepetitionsViewModel;

namespace Mayk_App.View.Admin.ChangeTablesPages;

public partial class RepetitionsListPage : ContentPage
{
	public RepetitionsListPage(RepetitionsListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}