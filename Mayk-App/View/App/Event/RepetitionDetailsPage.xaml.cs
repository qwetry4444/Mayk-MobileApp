using Mayk_App.ViewModel.App.Event;

namespace Mayk_App.View.App.Event;

public partial class RepetitionDetailsPage : ContentPage
{
	private readonly RepetitionDetailsViewModel viewModel;
	public RepetitionDetailsPage(RepetitionDetailsViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
        viewModel = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await viewModel.LoadRepetition();
    }
}