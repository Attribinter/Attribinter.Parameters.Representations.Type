namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamedFactory
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedFactoryMock.Object, result);
    }

    private IIndexedAndNamedTypeParameterRepresentationFactory Target() => Fixture.Sut.IndexedAndNamedFactory;
}
