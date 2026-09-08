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

	[Fact]
	public async Task GetUser_InvalidId_ThrowsException()
	{
		var users = new User();

		await Assert.ThrowsAsync<ArgumentException>(
			() => users.GetUserNameAsync(0));
	}


    [Theory]
    [InlineData(18, true)]
    [InlineData(20, true)]
    [InlineData(17, false)]
    [InlineData(30, true)]
    public void IsValidAge_ReturnsExpectedResult(
        int age,
        bool expected)
    {
        var users = new User();

        var result = users.IsValidAge(age);

        Assert.Equal(expected, result);
    }
}