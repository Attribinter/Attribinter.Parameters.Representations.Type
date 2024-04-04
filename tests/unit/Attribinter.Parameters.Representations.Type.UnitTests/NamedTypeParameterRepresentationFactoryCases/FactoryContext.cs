namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new NamedTypeParameterRepresentationFactory();

        return new(factory);
    }

    public INamedTypeParameterRepresentationFactory Factory { get; }

    private FactoryContext(INamedTypeParameterRepresentationFactory factory)
    {
        Factory = factory;
    }
}
