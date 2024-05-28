namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetName
{
    [Fact]
    public void ReturnsName()
    {
        var expected = "Name";

        var fixture = RepresentationFixtureFactory.Create(expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static string Target(
        IRepresentationFixture fixture)
    {
        return fixture.Sut.GetName();
    }
}
