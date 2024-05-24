namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

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

    private IIndexedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.IndexedFactory;
}
