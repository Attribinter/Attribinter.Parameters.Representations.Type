namespace Paraminter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

using System;

using Xunit;

public sealed class Create
{
    private ITypeParameterRepresentation Target(int index, string name) => Fixture.Sut.Create(index, name);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(0, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidIndexAndName_ReturnsRepresentation()
    {
        var result = Target(0, string.Empty);

        Assert.NotNull(result);
    }
}
