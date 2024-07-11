namespace Paraminter.Parameters.Representations.Type.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class IsNameKnown
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = FixtureFactory.Create(string.Empty);

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target(
        IFixture fixture)
    {
        return fixture.Sut.IsNameKnown;
    }
}
