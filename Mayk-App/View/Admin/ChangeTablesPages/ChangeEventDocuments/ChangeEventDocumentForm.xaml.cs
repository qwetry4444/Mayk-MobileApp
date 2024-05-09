using Mayk_App.ViewModel.Admin.ChangeTablesViewModel.ChangeEventDocuments;

namespace Mayk_App.View.Admin.ChangeTablesPages.ChangeEventDocuments;

public partial class ChangeEventDocumentForm : ContentPage
{
	private ChangeEventDocumentsFormViewModel viewModel;
	public ChangeEventDocumentForm(ChangeEventDocumentsFormViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.FillEntrys();
    }
}