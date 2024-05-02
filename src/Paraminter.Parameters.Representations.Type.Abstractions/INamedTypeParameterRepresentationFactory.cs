namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</summary>
public interface INamedTypeParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the name of the type parameter.</summary>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(string name);
}
