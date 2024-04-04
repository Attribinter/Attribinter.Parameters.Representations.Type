namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal sealed class RepresentationContext
{
    public static RepresentationContext Create(int index, string name)
    {
        IIndexedAndNamedTypeParameterRepresentationFactory factory = new IndexedAndNamedTypeParameterRepresentationFactory();

        var representation = factory.Create(index, name);

        return new(representation);
    }

    public ITypeParameterRepresentation Representation { get; }

    private RepresentationContext(ITypeParameterRepresentation representation)
    {
        Representation = representation;
    }
}
