namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Xunit;

public sealed class IsOrdinalKnown
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = FixtureFactory.Create(string.Empty);

        var result = Target(fixture);

        Assert.False(result);
    }

    private static bool Target(
        IFixture fixture)
    {
        return fixture.Sut.IsOrdinalKnown;
    }
}
