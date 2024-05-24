namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedFactory
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedFactoryMock.Object, result);
    }

    private IIndexedTypeParameterRepresentationFactory Target() => Fixture.Sut.IndexedFactory;
}
