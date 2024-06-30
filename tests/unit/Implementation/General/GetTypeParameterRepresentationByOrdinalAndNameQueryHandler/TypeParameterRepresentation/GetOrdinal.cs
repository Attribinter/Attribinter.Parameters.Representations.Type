namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Xunit;

public sealed class GetOrdinal
{
    [Fact]
    public void ReturnsOrdinal()
    {
        var expected = 42;

        var fixture = FixtureFactory.Create(expected, "Name");

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static int Target(
        IFixture fixture)
    {
        return fixture.Sut.GetOrdinal();
    }
}
