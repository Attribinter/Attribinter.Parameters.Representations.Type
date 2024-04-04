namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

using System;

using Xunit;

public sealed class Create
{
    private static ITypeParameterRepresentation Target(int index, string name) => Context.Factory.Create(index, name);

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(0, null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidIndexAndName_ReturnsNotNull()
    {
        var actual = Target(0, string.Empty);

        Assert.NotNull(actual);
    }
}
