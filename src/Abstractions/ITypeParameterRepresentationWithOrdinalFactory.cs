namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the ordinals of type parameters.</summary>
public interface ITypeParameterRepresentationWithOrdinalFactory
{
    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the ordinal of the type parameter.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(
        int ordinal);
}
