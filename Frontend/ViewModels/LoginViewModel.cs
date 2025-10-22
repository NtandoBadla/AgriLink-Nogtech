using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Services;
using System.Threading.Tasks;


namespace MyApp.ViewModels;


public partial class LoginViewModel : BaseViewModel
{
private readonly ILoginService _loginService;
private readonly INavigationService _nav;


public LoginViewModel(ILoginService loginService, INavigationService nav)
{
_loginService = loginService;
_nav = nav;
Title = "Sign In";
}


[ObservableProperty]
private string username = string.Empty;

[ObservableProperty]
private string password = string.Empty;

[ObservableProperty]
private string message = string.Empty;


[RelayCommand]
public async Task SignInAsync()
{
if (IsBusy) return;
try
{
IsBusy = true;
var ok = await _loginService.LoginAsync(Username, Password);
if (ok)
{
// Navigate to Home
await _nav.NavigateToAsync<HomeViewModel>();
}
else
{
Message = "Invalid credentials";
}
}
finally
{
IsBusy = false;
}
}
}