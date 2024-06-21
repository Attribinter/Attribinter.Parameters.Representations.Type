namespace Paraminter.Parameters.Representations;

using Xunit;

public sealed class Indexed
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedMock.Object, result);
    }

    private IIndexedTypeParameterRepresentationFactory Target() => Fixture.Sut.Indexed;
}
