using System.Windows;
using MyApp.ViewModels;

namespace MyApp.Views;

public partial class HomePage : Window
{
    public HomePage()
    {
        InitializeComponent();
        DataContext = new HomeViewModel();
    }

    private void LogoutButton_Click(object sender, RoutedEventArgs e)
    {
        var loginPage = new LoginPage();
        loginPage.Show();
        this.Close();
    }
}