namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationFactory
{
    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the index and name of the type parameter.</summary>
    /// <param name="index">The index of the type parameter.</param>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(int index, string name);

    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the index of the type parameter.</summary>
    /// <param name="index">The index of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(int index);

    /// <summary>Creates a <see cref="ITypeParameterRepresentation"/> using the name of the type parameter.</summary>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract ITypeParameterRepresentation Create(string name);
}
