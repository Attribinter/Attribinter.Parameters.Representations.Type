namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsNameKnown;

    [Fact]
    public void ReturnsTrue()
    {
        var fixture = RepresentationFixtureFactory.Create(0, string.Empty);

        var result = Target(fixture);

        Assert.True(result);
    }
}
