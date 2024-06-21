namespace Paraminter.Parameters.Representations;

/// <summary>Provides factories of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationEqualityComparerFactoryProvider
{
    /// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices and names of type parameter representations.</summary>
    public abstract IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IndexedAndNamed { get; }

    /// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</summary>
    public abstract IIndexedTypeParameterRepresentationEqualityComparerFactory Indexed { get; }

    /// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the names of type parameter representations.</summary>
    public abstract INamedTypeParameterRepresentationEqualityComparerFactory Named { get; }
}
