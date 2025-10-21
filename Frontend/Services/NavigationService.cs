using System.Windows;
using MyApp.Views;

namespace MyApp.Services;

public class NavigationService : INavigationService
{
    public NavigationService()
    {
    }

    public async Task NavigateToAsync<TViewModel>() where TViewModel : class
    {
        await Task.Run(() =>
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                if (typeof(TViewModel).Name == "HomeViewModel")
                {
                    var homePage = new HomePage();
                    homePage.Show();
                }
            });
        });
    }

    public async Task GoBackAsync()
    {
        await Task.CompletedTask;
    }
}