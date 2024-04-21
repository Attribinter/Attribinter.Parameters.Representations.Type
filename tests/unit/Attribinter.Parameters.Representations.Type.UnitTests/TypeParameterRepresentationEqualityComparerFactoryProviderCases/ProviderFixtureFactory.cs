namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

internal static class ProviderFixtureFactory
{
    public static IProviderFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> indexedAndNamedFactoryMock = new();
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> indexedFactoryMock = new();
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> namedFactoryMock = new();

        var sut = new TypeParameterRepresentationEqualityComparerFactoryProvider(indexedAndNamedFactoryMock.Object, indexedFactoryMock.Object, namedFactoryMock.Object);

        return new ProviderFixture(sut, indexedAndNamedFactoryMock, indexedFactoryMock, namedFactoryMock);
    }

    private sealed class ProviderFixture : IProviderFixture
    {
        private readonly ITypeParameterRepresentationEqualityComparerFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedFactoryMock;
        private readonly Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedFactoryMock;
        private readonly Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedFactoryMock;

        public ProviderFixture(ITypeParameterRepresentationEqualityComparerFactoryProvider sut, Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> indexedAndNamedFactoryMock, Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> indexedFactoryMock, Mock<INamedTypeParameterRepresentationEqualityComparerFactory> namedFactoryMock)
        {
            Sut = sut;

            IndexedAndNamedFactoryMock = indexedAndNamedFactoryMock;
            IndexedFactoryMock = indexedFactoryMock;
            NamedFactoryMock = namedFactoryMock;
        }

        ITypeParameterRepresentationEqualityComparerFactoryProvider IProviderFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.IndexedAndNamedFactoryMock => IndexedAndNamedFactoryMock;
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.IndexedFactoryMock => IndexedFactoryMock;
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.NamedFactoryMock => NamedFactoryMock;
    }
}
