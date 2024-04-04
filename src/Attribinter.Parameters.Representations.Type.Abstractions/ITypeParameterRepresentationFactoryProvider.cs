namespace Attribinter.Parameters.Representations;

/// <summary>Provides factories of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationFactoryProvider
{
    /// <summary>The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</summary>
    public abstract IIndexedAndNamedTypeParameterRepresentationFactory IndexedAndNamedFactory { get; }

    /// <summary>The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</summary>
    public abstract IIndexedTypeParameterRepresentationFactory IndexedFactory { get; }

    /// <summary>The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</summary>
    public abstract INamedTypeParameterRepresentationFactory NamedFactory { get; }
}
