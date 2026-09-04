namespace test;

using Moq;
using Xunit;

public class OktaerviceTests
{
    [Fact]
    public async Task IsUserAuthenticatedAsync_WhenTokenExists_ReturnsTrue()
    {

        var oktaMock = new Mock<IOktaService>();

        oktaMock
            .Setup(x => x.GetTokenAsync())
            .ReturnsAsync("fake-okta-token");

        var service = new UserService(oktaMock.Object);

        var result = await service.IsUserAuthenticatedAsync();

        Assert.True(result);
    }
}