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
}