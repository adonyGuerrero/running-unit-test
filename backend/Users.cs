//Adding comments to class to push changes
public class User
{
    public async Task<string> GetUserNameAsync(int userId)
    {
        await Task.Delay(100);
		
		if (userId <= 0)
		{
			throw new ArgumentException(
				"Invalid user id");
		}
			return "Test User";
    }
	

	public bool IsValidAge(int age)
	{
		return age >= 18;
	}
}