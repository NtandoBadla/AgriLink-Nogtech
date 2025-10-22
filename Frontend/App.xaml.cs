using System.Windows;
using MyApp.Views;

namespace MyApp;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var loginWindow = new LoginPage();
        loginWindow.Show();
    }
}