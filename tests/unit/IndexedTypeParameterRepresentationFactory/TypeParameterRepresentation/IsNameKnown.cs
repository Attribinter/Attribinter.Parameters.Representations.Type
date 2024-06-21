namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Xunit;

public sealed class IsNameKnown
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = FixtureFactory.Create(0);

        var resuöt = Target(fixture);

        Assert.False(resuöt);
    }

    private static bool Target(
        IFixture fixture)
    {
        return fixture.Sut.IsNameKnown;
    }
}
