using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mayk_App.Model;
using Mayk_App.Service;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;



namespace Mayk_App.ViewModel.App
{
    [QueryProperty(nameof(UserId), "userId")]
    public partial class MainViewModel : ObservableObject
    {
        private readonly IUserService _userService;
        private readonly IRepetitionService _repetitionService;


        public ObservableRangeCollection<User> Users { get; set; }
        public ObservableRangeCollection<Repetition> Repetitions { get; set; }

        public MainViewModel(IUserService userService, IRepetitionService repetitionService)
        {
            _userService = userService;
            _repetitionService = repetitionService;
            Users = new ObservableRangeCollection<User>();
            Repetitions = new ObservableRangeCollection<Repetition>();
        }


        [ObservableProperty]
        int userId;

        [RelayCommand]
        async Task getUsers()
        {
            Users.AddRange(await _userService.GetAsync());

            Console.WriteLine("!!!!![");
            Console.WriteLine(Users);
            Console.WriteLine("]!!!!!");
        }

        [RelayCommand]
        async Task getUser()
        {
            Users.Add(await _userService.GetUserByEmail("5"));
        }


        [RelayCommand]
        async Task Refresh()
        {
            //IsBusy = true;
            //await Task.Delay(2000);

            //var user = await _repetitionService.GetUserByEmail("2");
            //Users.Add(user);

            Users.Clear();
            List<User> users = await _userService.GetAsync();
            Users.AddRange(users);

            //IsBusy = false;
        }

        [RelayCommand]
        async Task GetRepetition()
        {
            List<Repetition> repetitions = await _repetitionService.GetAsync();
            Repetitions.AddRange(repetitions);
        }

        [ObservableProperty]
        private string _userFirstName;
    }


}
