namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidName_ReturnsRepresentation()
    {
        var result = Target(string.Empty);

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(string name) => Fixture.Sut.Create(name);
}
