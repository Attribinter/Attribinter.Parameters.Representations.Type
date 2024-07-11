namespace Paraminter.Parameters.Representations.Type.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class IsNameKnown
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = FixtureFactory.Create(0);

        var result = Target(fixture);

        Assert.False(result);
    }

    private static bool Target(
        IFixture fixture)
    {
        return fixture.Sut.IsNameKnown;
    }
}
