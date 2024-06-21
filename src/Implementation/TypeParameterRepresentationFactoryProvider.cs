namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationFactoryProvider"/>
public sealed class TypeParameterRepresentationFactoryProvider
    : ITypeParameterRepresentationFactoryProvider
{
    private readonly IIndexedAndNamedTypeParameterRepresentationFactory IndexedAndNamed;
    private readonly IIndexedTypeParameterRepresentationFactory Indexed;
    private readonly INamedTypeParameterRepresentationFactory Named;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationFactoryProvider"/>, providing factories of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="indexedAndNamed">Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</param>
    /// <param name="indexed">Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</param>
    /// <param name="named">Handles creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</param>
    public TypeParameterRepresentationFactoryProvider(
        IIndexedAndNamedTypeParameterRepresentationFactory indexedAndNamed,
        IIndexedTypeParameterRepresentationFactory indexed,
        INamedTypeParameterRepresentationFactory named)
    {
        IndexedAndNamed = indexedAndNamed ?? throw new ArgumentNullException(nameof(indexedAndNamed));
        Indexed = indexed ?? throw new ArgumentNullException(nameof(indexed));
        Named = named ?? throw new ArgumentNullException(nameof(named));
    }

    IIndexedAndNamedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.IndexedAndNamed => IndexedAndNamed;
    IIndexedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.Indexed => Indexed;
    INamedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.Named => Named;
}
