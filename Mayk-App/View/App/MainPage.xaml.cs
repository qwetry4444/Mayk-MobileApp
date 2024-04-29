using Mayk_App.ViewModel.App;

namespace Mayk_App.View.App;

public partial class MainPage : ContentPage
{
    private MainViewModel viewModel;
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        this.viewModel = vm;
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}


