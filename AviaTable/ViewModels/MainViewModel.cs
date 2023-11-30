using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AviaTable.Infrastructure;
using AviaTable.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AviaTable.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IUserService _userService;
    private readonly IPathProvider _pathProvider;
    
    [ObservableProperty] private ObservableCollection<User> _users;

    public MainViewModel()
    {
        _pathProvider = new PathProvider();
        _userService = new UserService(_pathProvider);
        Users = new ObservableCollection<User>();
    }

    [RelayCommand]
    private async Task Save()
    {
        await _userService.Save(Users);
    }

    [RelayCommand]
    private async Task Load()
    {
        var users = await _userService.Load();

        Users = new ObservableCollection<User>(users);
    }
}