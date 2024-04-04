namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal sealed class RepresentationContext
{
    public static RepresentationContext Create(string name)
    {
        INamedTypeParameterRepresentationFactory factory = new NamedTypeParameterRepresentationFactory();

        var representation = factory.Create(name);

        return new(representation);
    }

    public ITypeParameterRepresentation Representation { get; }

    private RepresentationContext(ITypeParameterRepresentation representation)
    {
        Representation = representation;
    }
}
