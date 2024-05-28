namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = RepresentationFixtureFactory.Create(0);

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target(
        IRepresentationFixture fixture)
    {
        return fixture.Sut.IsIndexKnown;
    }
}
