namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal sealed class RepresentationContext
{
    public static RepresentationContext Create(int index)
    {
        IIndexedTypeParameterRepresentationFactory factory = new IndexedTypeParameterRepresentationFactory();

        var representation = factory.Create(index);

        return new(representation);
    }

    public ITypeParameterRepresentation Representation { get; }

    private RepresentationContext(ITypeParameterRepresentation representation)
    {
        Representation = representation;
    }
}
