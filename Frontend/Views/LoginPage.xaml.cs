using System.Windows;
using MyApp.ViewModels;

namespace MyApp.Views;

public partial class LoginPage : Window
{
    public LoginPage()
    {
        InitializeComponent();
        DataContext = new LoginViewModel(new Services.MockLoginService(), new Services.NavigationService());
    }
}