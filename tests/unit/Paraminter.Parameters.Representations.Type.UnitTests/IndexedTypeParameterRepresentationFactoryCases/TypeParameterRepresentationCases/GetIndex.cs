namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetIndex
{
    [Fact]
    public void ReturnsIndex()
    {
        var expected = 42;

        var fixture = RepresentationFixtureFactory.Create(expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static int Target(
        IRepresentationFixture fixture)
    {
        return fixture.Sut.GetIndex();
    }
}
