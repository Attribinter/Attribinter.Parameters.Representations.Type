namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationFactoryProvider"/>
public sealed class TypeParameterRepresentationFactoryProvider : ITypeParameterRepresentationFactoryProvider
{
    private readonly IIndexedAndNamedTypeParameterRepresentationFactory IndexedAndNamedFactory;
    private readonly IIndexedTypeParameterRepresentationFactory IndexedFactory;
    private readonly INamedTypeParameterRepresentationFactory NamedFactory;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationFactoryProvider"/>, providing factories of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="indexedAndNamedFactory">The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</param>
    /// <param name="indexedFactory">The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</param>
    /// <param name="namedFactory">The factory handling creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</param>
    public TypeParameterRepresentationFactoryProvider(IIndexedAndNamedTypeParameterRepresentationFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationFactory indexedFactory, INamedTypeParameterRepresentationFactory namedFactory)
    {
        IndexedAndNamedFactory = indexedAndNamedFactory ?? throw new ArgumentNullException(nameof(indexedAndNamedFactory));
        IndexedFactory = indexedFactory ?? throw new ArgumentNullException(nameof(indexedFactory));
        NamedFactory = namedFactory ?? throw new ArgumentNullException(nameof(namedFactory));
    }

    IIndexedAndNamedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.IndexedAndNamedFactory => IndexedAndNamedFactory;
    IIndexedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.IndexedFactory => IndexedFactory;
    INamedTypeParameterRepresentationFactory ITypeParameterRepresentationFactoryProvider.NamedFactory => NamedFactory;
}
