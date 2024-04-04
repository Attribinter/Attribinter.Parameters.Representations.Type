namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Create
{
    private static ITypeParameterRepresentation Target(int index) => Context.Factory.Create(index);

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ValidIndex_ReturnsNotNull()
    {
        var actual = Target(0);

        Assert.NotNull(actual);
    }
}
