//Adding comments to class to push changes
public class User
{
    public async Task<string> GetUserNameAsync(int userId)
    {
        await Task.Delay(100);

        return "Test User";
    }
}