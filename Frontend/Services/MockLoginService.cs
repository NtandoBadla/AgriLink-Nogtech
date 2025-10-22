namespace MyApp.Services;


public class MockLoginService : ILoginService
{
public Task<bool> LoginAsync(string username, string password)
{
// Placeholder — replace with real API calls
return Task.FromResult(username == "test" && password == "password");
}
}