namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var indexedAndNamedFactory = Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>();
        var indexedFactory = Mock.Of<IIndexedTypeParameterRepresentationFactory>();
        var namedFactory = Mock.Of<INamedTypeParameterRepresentationFactory>();

        var provider = new TypeParameterRepresentationFactoryProvider(indexedAndNamedFactory, indexedFactory, namedFactory);

        return new(provider, indexedAndNamedFactory, indexedFactory, namedFactory);
    }

    public ITypeParameterRepresentationFactoryProvider Provider { get; }

    public IIndexedAndNamedTypeParameterRepresentationFactory IndexedAndNamedFactory { get; }
    public IIndexedTypeParameterRepresentationFactory IndexedFactory { get; }
    public INamedTypeParameterRepresentationFactory NamedFactory { get; }

    private ProviderContext(ITypeParameterRepresentationFactoryProvider provider, IIndexedAndNamedTypeParameterRepresentationFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationFactory indexedFactory, INamedTypeParameterRepresentationFactory namedFactory)
    {
        Provider = provider;

        IndexedAndNamedFactory = indexedAndNamedFactory;
        IndexedFactory = indexedFactory;
        NamedFactory = namedFactory;
    }
}
