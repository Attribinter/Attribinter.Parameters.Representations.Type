namespace Paraminter.Parameters.Representations;

using Xunit;

public sealed class Named
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.NamedMock.Object, result);
    }

    private INamedTypeParameterRepresentationFactory Target() => Fixture.Sut.Named;
}
