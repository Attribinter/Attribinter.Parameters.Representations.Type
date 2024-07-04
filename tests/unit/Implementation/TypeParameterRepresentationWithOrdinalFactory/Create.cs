namespace Paraminter.Parameters.Representations;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsRepresentation()
    {
        var result = Target(42);

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        int ordinal)
    {
        return Fixture.Sut.Create(ordinal);
    }
}
