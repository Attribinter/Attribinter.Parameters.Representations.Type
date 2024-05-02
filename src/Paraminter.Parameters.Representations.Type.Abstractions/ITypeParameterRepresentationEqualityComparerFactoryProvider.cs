namespace Paraminter.Parameters.Representations;

/// <summary>Provides factories of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationEqualityComparerFactoryProvider
{
    /// <summary>The factory of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices and names of type parameter representations.</summary>
    public abstract IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IndexedAndNamedFactory { get; }

    /// <summary>The factory of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</summary>
    public abstract IIndexedTypeParameterRepresentationEqualityComparerFactory IndexedFactory { get; }

    /// <summary>The factory of comparers of <see cref="ITypeParameterRepresentation"/> which consider the names of type parameter representations.</summary>
    public abstract INamedTypeParameterRepresentationEqualityComparerFactory NamedFactory { get; }
}
