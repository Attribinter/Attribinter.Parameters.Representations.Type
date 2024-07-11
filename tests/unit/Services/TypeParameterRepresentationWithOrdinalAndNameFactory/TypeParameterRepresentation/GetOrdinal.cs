namespace Paraminter.Parameters.Representations.Type.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class GetOrdinal
{
    [Fact]
    public void ReturnsOrdinal()
    {
        var fixture = FixtureFactory.Create(42, "Name");

        var result = Target(fixture);

        Assert.Equal(fixture.Ordinal, result);
    }

    private static int Target(
        IFixture fixture)
    {
        return fixture.Sut.GetOrdinal();
    }
}
