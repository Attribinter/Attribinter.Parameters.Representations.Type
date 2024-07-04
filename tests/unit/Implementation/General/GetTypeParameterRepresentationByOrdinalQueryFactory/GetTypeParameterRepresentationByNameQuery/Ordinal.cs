namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class Ordinal
{
    [Fact]
    public void ReturnsOrdinal()
    {
        var fixture = FixtureFactory.Create(42);

        var result = Target(fixture);

        Assert.Equal(fixture.Ordinal, result);
    }

    private static int Target(
        IFixture fixture)
    {
        return fixture.Sut.Ordinal;
    }
}
