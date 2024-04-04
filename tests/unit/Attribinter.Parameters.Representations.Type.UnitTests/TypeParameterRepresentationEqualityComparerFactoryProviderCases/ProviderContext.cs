namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var indexedAndNamedFactory = Mock.Of<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>();
        var indexedFactory = Mock.Of<IIndexedTypeParameterRepresentationEqualityComparerFactory>();
        var namedFactory = Mock.Of<INamedTypeParameterRepresentationEqualityComparerFactory>();

        var provider = new TypeParameterRepresentationEqualityComparerFactoryProvider(indexedAndNamedFactory, indexedFactory, namedFactory);

        return new(provider, indexedAndNamedFactory, indexedFactory, namedFactory);
    }

    public ITypeParameterRepresentationEqualityComparerFactoryProvider Provider { get; }

    public IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IndexedAndNamedFactory { get; }
    public IIndexedTypeParameterRepresentationEqualityComparerFactory IndexedFactory { get; }
    public INamedTypeParameterRepresentationEqualityComparerFactory NamedFactory { get; }

    private ProviderContext(ITypeParameterRepresentationEqualityComparerFactoryProvider provider, IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationEqualityComparerFactory indexedFactory, INamedTypeParameterRepresentationEqualityComparerFactory namedFactory)
    {
        Provider = provider;

        IndexedAndNamedFactory = indexedAndNamedFactory;
        IndexedFactory = indexedFactory;
        NamedFactory = namedFactory;
    }
}
