namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class IsOrdinalKnown
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = FixtureFactory.Create(0);

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target(
        IFixture fixture)
    {
        return fixture.Sut.IsOrdinalKnown;
    }
}
