using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class MainPage : ContentPage
{
    private MainViewModel viewModel;
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        viewModel = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.GetUser();
        await viewModel.LoadNearestEvent();
    }
}


