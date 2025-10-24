using System.Windows;

namespace MyApp.Views;

public partial class DriverDashboard : Window
{
    public DriverDashboard()
    {
        InitializeComponent();
    }

    private void LogoutButton_Click(object sender, RoutedEventArgs e)
    {
        var loginPage = new LoginPage();
        loginPage.Show();
        this.Close();
    }
}