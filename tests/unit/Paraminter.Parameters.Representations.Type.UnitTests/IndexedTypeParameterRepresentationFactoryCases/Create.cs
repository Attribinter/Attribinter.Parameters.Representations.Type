namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Create
{
    private ITypeParameterRepresentation Target(int index) => Fixture.Sut.Create(index);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void ValidIndex_ReturnsRepresentation()
    {
        var result = Target(0);

        Assert.NotNull(result);
    }
}
