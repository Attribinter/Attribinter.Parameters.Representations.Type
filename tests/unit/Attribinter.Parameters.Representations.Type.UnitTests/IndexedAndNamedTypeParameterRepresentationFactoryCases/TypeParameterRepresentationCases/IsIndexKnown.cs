namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = RepresentationFixtureFactory.Create(0, string.Empty);

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsIndexKnown;
}
