namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</summary>
public interface IIndexedTypeParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the index of the type parameter.</summary>
    /// <param name="index">The index of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(
        int index);
}
