namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class Named
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.NamedMock.Object, result);
    }

    private INamedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.Named;
}
