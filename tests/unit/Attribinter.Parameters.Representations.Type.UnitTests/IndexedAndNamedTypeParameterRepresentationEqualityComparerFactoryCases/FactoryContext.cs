namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory();

        return new(factory);
    }

    public IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Factory { get; }

    private FactoryContext(IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory factory)
    {
        Factory = factory;
    }
}
