namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the ordinals and names of type parameters.</summary>
public interface ITypeParameterRepresentationWithOrdinalAndNameFactory
{
    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the ordinal and name of the type parameter.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(
        int ordinal,
        string name);
}
