namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases;

using System;

using Xunit;

public sealed class Create
{
    private static ITypeParameterRepresentation Target(string name) => Context.Factory.Create(name);

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidName_ReturnsNotNull()
    {
        var actual = Target(string.Empty);

        Assert.NotNull(actual);
    }
}
