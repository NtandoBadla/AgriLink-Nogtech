using System.Windows;
using MyApp.ViewModels;

namespace MyApp.Views;

public partial class LoginPage : Window
{
    public LoginPage()
    {
        InitializeComponent();
        var viewModel = new LoginViewModel(new Services.MockLoginService(), new Services.NavigationService());
        viewModel.LoginPage = this;
        DataContext = viewModel;
    }

    private void SignUpButton_Click(object sender, RoutedEventArgs e)
    {
        var signUpPage = new SignUpPage();
        signUpPage.Show();
        this.Close();
    }
}