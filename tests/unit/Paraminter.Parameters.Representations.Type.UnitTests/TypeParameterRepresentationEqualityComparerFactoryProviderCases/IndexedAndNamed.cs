namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamed
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedMock.Object, result);
    }

    private IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.IndexedAndNamed;
}
