namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

using System.Collections.Generic;

using Xunit;

public sealed class Create
{
    private static IEqualityComparer<ITypeParameterRepresentation> Target() => Context.Factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsNotNull()
    {
        var actual = Target();

        Assert.NotNull(actual);
    }
}
