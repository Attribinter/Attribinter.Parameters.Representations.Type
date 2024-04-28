namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    [Fact]
    public void ReturnsTrue()
    {
        var fixture = RepresentationFixtureFactory.Create(string.Empty);

        var result = Target(fixture);

        Assert.True(result);
    }

    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsNameKnown;
}
