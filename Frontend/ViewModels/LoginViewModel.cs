using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Services;
using MyApp.Views;
using System.Threading.Tasks;
using System.Windows;

namespace MyApp.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    private readonly ILoginService _loginService;
    private readonly INavigationService _nav;
    public LoginPage? LoginPage { get; set; }

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
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Window dashboard;
                    if (LoginPage?.FarmerRadio.IsChecked == true)
                    {
                        dashboard = new HomePage();
                    }
                    else if (LoginPage?.DriverRadio.IsChecked == true)
                    {
                        dashboard = new DriverDashboard();
                    }
                    else
                    {
                        dashboard = new BuyerDashboard();
                    }
                    dashboard.Show();
                    LoginPage?.Close();
                });
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