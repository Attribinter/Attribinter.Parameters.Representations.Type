namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetName
{
    private static string Target(IRepresentationFixture fixture) => fixture.Sut.GetName();

    [Fact]
    public void ReturnsNameConstructedWith()
    {
        var expected = "Name";

        var fixture = RepresentationFixtureFactory.Create(expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }
}
