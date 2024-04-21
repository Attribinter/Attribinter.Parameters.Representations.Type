namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsIndexKnown;

    [Fact]
    public void ReturnsTrue()
    {
        var fixture = RepresentationFixtureFactory.Create(0);

        var result = Target(fixture);

        Assert.True(result);
    }
}
