namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = RepresentationFixtureFactory.Create(0);

        var resuöt = Target(fixture);

        Assert.False(resuöt);
    }

    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsNameKnown;
}
