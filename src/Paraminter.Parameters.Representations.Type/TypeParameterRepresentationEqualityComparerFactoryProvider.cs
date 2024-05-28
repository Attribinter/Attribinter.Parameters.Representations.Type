namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationEqualityComparerFactoryProvider"/>
public sealed class TypeParameterRepresentationEqualityComparerFactoryProvider
    : ITypeParameterRepresentationEqualityComparerFactoryProvider
{
    private readonly IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IndexedAndNamed;
    private readonly IIndexedTypeParameterRepresentationEqualityComparerFactory Indexed;
    private readonly INamedTypeParameterRepresentationEqualityComparerFactory Named;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationEqualityComparerFactoryProvider"/>, providing factories of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="indexedAndNamed">Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices and names of type parameter representations.</param>
    /// <param name="indexed">Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</param>
    /// <param name="named">Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the names of type parameter representations.</param>
    public TypeParameterRepresentationEqualityComparerFactoryProvider(
        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory indexedAndNamed,
        IIndexedTypeParameterRepresentationEqualityComparerFactory indexed,
        INamedTypeParameterRepresentationEqualityComparerFactory named)
    {
        IndexedAndNamed = indexedAndNamed ?? throw new ArgumentNullException(nameof(indexedAndNamed));
        Indexed = indexed ?? throw new ArgumentNullException(nameof(indexed));
        Named = named ?? throw new ArgumentNullException(nameof(named));
    }

    IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.IndexedAndNamed => IndexedAndNamed;
    IIndexedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.Indexed => Indexed;
    INamedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.Named => Named;
}
