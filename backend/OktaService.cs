public class UserService
{
    private readonly IOktaService _oktaService;

    public UserService(IOktaService oktaService)
    {
        _oktaService = oktaService;
    }

    public async Task<bool> IsUserAuthenticatedAsync()
    {
        var token = await _oktaService.GetTokenAsync();

        return !string.IsNullOrEmpty(token);
    }
}