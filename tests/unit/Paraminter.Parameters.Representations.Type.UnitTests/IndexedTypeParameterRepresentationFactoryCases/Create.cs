namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

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
