namespace Paraminter.Parameters.Representations;

using Xunit;

public sealed class IndexedAndNamed
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedMock.Object, result);
    }

    private IIndexedAndNamedTypeParameterRepresentationFactory Target() => Fixture.Sut.IndexedAndNamed;
}
