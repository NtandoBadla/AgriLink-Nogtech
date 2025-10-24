using System.Windows;

namespace MyApp.Views;

public partial class SignUpPage : Window
{
    public SignUpPage()
    {
        InitializeComponent();
    }

    private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
    {
        var loginPage = new LoginPage();
        loginPage.Show();
        this.Close();
    }

    private void BackToLoginButton_Click(object sender, RoutedEventArgs e)
    {
        var loginPage = new LoginPage();
        loginPage.Show();
        this.Close();
    }
}