using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit.Abstractions;

namespace my_contribution_test;

public class MinimalApiTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public MinimalApiTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task TestApi_Test_ShouldPass()
    {
        // Arrange
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        // Act
        var response = await client.GetStringAsync("/test");
        
        // Assert
        Assert.Equal($"test", response);
    }
}