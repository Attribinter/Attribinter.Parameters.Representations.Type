namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class NamedFactory
{
    private INamedTypeParameterRepresentationFactory Target() => Fixture.Sut.NamedFactory;

    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.NamedFactoryMock.Object, result);
    }
}
