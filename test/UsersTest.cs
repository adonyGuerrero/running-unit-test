using Xunit;

public class UsersTest
{
    [Fact]
    public async Task Test()
    {
        var users = new User();
        var result = await users.GetUserNameAsync(1);

        Console.WriteLine(result);

        Assert.Equal("Test User", result);
    }

}