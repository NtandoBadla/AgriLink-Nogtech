using System.Windows;

namespace MyApp.Views;

public partial class BuyerDashboard : Window
{
    public BuyerDashboard()
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