namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Xunit;

public sealed class IsIndexKnown
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
        return fixture.Sut.IsIndexKnown;
    }
}
