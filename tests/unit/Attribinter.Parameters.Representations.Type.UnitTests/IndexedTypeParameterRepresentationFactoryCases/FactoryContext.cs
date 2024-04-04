namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new IndexedTypeParameterRepresentationFactory();

        return new(factory);
    }

    public IIndexedTypeParameterRepresentationFactory Factory { get; }

    private FactoryContext(IIndexedTypeParameterRepresentationFactory factory)
    {
        Factory = factory;
    }
}
