namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class Named
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.NamedMock.Object, result);
    }

    private INamedTypeParameterRepresentationFactory Target() => Fixture.Sut.Named;
}
