namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationEqualityComparerFactoryProvider"/>
public sealed class TypeParameterRepresentationEqualityComparerFactoryProvider : ITypeParameterRepresentationEqualityComparerFactoryProvider
{
    private readonly IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IndexedAndNamedFactory;
    private readonly IIndexedTypeParameterRepresentationEqualityComparerFactory IndexedFactory;
    private readonly INamedTypeParameterRepresentationEqualityComparerFactory NamedFactory;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationEqualityComparerFactoryProvider"/>, providing factories of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="indexedAndNamedFactory">The factory handling creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices and names of type parameter representations.</param>
    /// <param name="indexedFactory">The factory handling creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</param>
    /// <param name="namedFactory">The factory handling creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the names of type parameter representations.</param>
    public TypeParameterRepresentationEqualityComparerFactoryProvider(IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationEqualityComparerFactory indexedFactory, INamedTypeParameterRepresentationEqualityComparerFactory namedFactory)
    {
        IndexedAndNamedFactory = indexedAndNamedFactory ?? throw new ArgumentNullException(nameof(indexedAndNamedFactory));
        IndexedFactory = indexedFactory ?? throw new ArgumentNullException(nameof(indexedFactory));
        NamedFactory = namedFactory ?? throw new ArgumentNullException(nameof(namedFactory));
    }

    IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.IndexedAndNamedFactory => IndexedAndNamedFactory;
    IIndexedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.IndexedFactory => IndexedFactory;
    INamedTypeParameterRepresentationEqualityComparerFactory ITypeParameterRepresentationEqualityComparerFactoryProvider.NamedFactory => NamedFactory;
}
