namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamedFactory
{
    private IIndexedAndNamedTypeParameterRepresentationFactory Target() => Fixture.Sut.IndexedAndNamedFactory;

    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedFactoryMock.Object, result);
    }
}
