namespace MyApp.Services;


public interface INavigationService
{
Task NavigateToAsync<TViewModel>() where TViewModel : class;
Task GoBackAsync();
}