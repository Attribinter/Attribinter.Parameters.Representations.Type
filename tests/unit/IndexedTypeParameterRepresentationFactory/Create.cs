namespace Paraminter.Parameters.Representations;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ValidIndex_ReturnsRepresentation()
    {
        var result = Target(0);

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        int index)
    {
        return Fixture.Sut.Create(index);
    }
}
