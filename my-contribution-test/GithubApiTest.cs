using LaYumba.Functional;
using my_contribution;
using Xunit.Abstractions;

namespace my_contribution_test;

public class GithubApiTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public GithubApiTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Test()
    {
        await GithubApi.GetReposAsync("es5h")
            .ForEachAsync(response => _testOutputHelper.WriteLine(response.ToString()));

    }
}