namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class Indexed
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedMock.Object, result);
    }

    private IIndexedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.Indexed;
}
