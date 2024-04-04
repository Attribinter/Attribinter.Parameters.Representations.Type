namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        var factory = new NamedTypeParameterRepresentationEqualityComparerFactory();

        return new(factory);
    }

    public INamedTypeParameterRepresentationEqualityComparerFactory Factory { get; }

    private FactoryContext(INamedTypeParameterRepresentationEqualityComparerFactory factory)
    {
        Factory = factory;
    }
}
