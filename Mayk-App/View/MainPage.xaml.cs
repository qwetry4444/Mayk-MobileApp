using Mayk_App.ViewModel;

namespace Mayk_App.View;

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


