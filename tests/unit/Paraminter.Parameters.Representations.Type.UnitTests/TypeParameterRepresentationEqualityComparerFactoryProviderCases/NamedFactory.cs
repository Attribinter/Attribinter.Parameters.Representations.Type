namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class NamedFactory
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.NamedFactoryMock.Object, result);
    }

    private INamedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.NamedFactory;
}
