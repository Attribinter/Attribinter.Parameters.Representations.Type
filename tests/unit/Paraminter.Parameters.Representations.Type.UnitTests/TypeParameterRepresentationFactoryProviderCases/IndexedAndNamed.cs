namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamed
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedMock.Object, result);
    }

    private IIndexedAndNamedTypeParameterRepresentationFactory Target() => Fixture.Sut.IndexedAndNamed;
}
