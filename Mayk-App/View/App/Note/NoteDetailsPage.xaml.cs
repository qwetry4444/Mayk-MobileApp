using Mayk_App.ViewModel.App.Notes;

namespace Mayk_App.View.App.Note;

public partial class NoteDetailsPage : ContentPage
{
	private NoteDetailsViewModel viewModel;
	public NoteDetailsPage(NoteDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadNote();
    }
}