using NUnit.Framework;

namespace my_contribution;

public static class TestService
{
    [TestCase("identity", ExpectedResult = "identity")]
    public static async Task<string> IdentityStringAsync(string id) => await Task.FromResult(id);
    
    public static async Task<string> ReturnTestAsync() =>  await Task.FromResult("test");
}