using Mayk_App.ViewModel.App.Notes;

namespace Mayk_App.View.App.Note;

public partial class NoteDetailsPage : ContentPage
{
	public NoteDetailsPage(NoteDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}