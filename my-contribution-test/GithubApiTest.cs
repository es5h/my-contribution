using System.Text.Json;
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
        _testOutputHelper.WriteLine(GithubApi.GetReposAsync("es5h").ToString());
    }
}