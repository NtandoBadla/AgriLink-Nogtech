using System;
using System.Windows;

namespace MyApp;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var app = new App();
        app.Run();
    }
}