namespace MyApp.Services;


public interface ILoginService
{
Task<bool> LoginAsync(string username, string password);
}