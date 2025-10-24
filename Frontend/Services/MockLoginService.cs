namespace MyApp.Services;


public class MockLoginService : ILoginService
{
public Task<bool> LoginAsync(string username, string password)
{
return Task.FromResult(true);
}
}