namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new IndexedAndNamedTypeParameterRepresentationFactory();

        return new(factory);
    }

    public IIndexedAndNamedTypeParameterRepresentationFactory Factory { get; }

    private FactoryContext(IIndexedAndNamedTypeParameterRepresentationFactory factory)
    {
        Factory = factory;
    }
}
