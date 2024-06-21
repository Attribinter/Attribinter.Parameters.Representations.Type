namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Xunit;

public sealed class GetIndex
{
    [Fact]
    public void ReturnsIndex()
    {
        var expected = 42;

        var fixture = FixtureFactory.Create(expected, string.Empty);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static int Target(
        IFixture fixture)
    {
        return fixture.Sut.GetIndex();
    }
}
