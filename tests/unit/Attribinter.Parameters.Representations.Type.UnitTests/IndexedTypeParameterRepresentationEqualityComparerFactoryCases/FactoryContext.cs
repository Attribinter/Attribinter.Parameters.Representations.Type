namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new IndexedTypeParameterRepresentationEqualityComparerFactory();

        return new(factory);
    }

    public IIndexedTypeParameterRepresentationEqualityComparerFactory Factory { get; }

    private FactoryContext(IIndexedTypeParameterRepresentationEqualityComparerFactory factory)
    {
        Factory = factory;
    }
}
