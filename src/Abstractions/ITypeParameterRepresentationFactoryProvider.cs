namespace Paraminter.Parameters.Representations;

/// <summary>Provides factories of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationFactoryProvider
{
    /// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</summary>
    public abstract IIndexedAndNamedTypeParameterRepresentationFactory IndexedAndNamed { get; }

    /// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</summary>
    public abstract IIndexedTypeParameterRepresentationFactory Indexed { get; }

    /// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</summary>
    public abstract INamedTypeParameterRepresentationFactory Named { get; }
}
