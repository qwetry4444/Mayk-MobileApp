using Mayk_App.Service;
using Mayk_App.ViewModel.App.Notes;

namespace Mayk_App.View.App.Note;

public partial class NotesListPage : ContentPage
{
	private NotesListViewModel viewModel;
	public NotesListPage(NotesListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        viewModel = vm;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadNotes();
    }
}