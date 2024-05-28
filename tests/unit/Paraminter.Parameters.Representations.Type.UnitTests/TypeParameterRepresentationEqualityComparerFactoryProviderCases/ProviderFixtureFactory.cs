namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

internal static class ProviderFixtureFactory
{
    public static IProviderFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> indexedAndNamedMock = new();
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> indexedMock = new();
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> namedMock = new();

        var sut = new TypeParameterRepresentationEqualityComparerFactoryProvider(indexedAndNamedMock.Object, indexedMock.Object, namedMock.Object);

        return new ProviderFixture(sut, indexedAndNamedMock, indexedMock, namedMock);
    }

    private sealed class ProviderFixture
        : IProviderFixture
    {
        private readonly ITypeParameterRepresentationEqualityComparerFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedMock;
        private readonly Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedMock;
        private readonly Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedMock;

        public ProviderFixture(
            ITypeParameterRepresentationEqualityComparerFactoryProvider sut,
            Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> indexedAndNamedMock,
            Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> indexedMock,
            Mock<INamedTypeParameterRepresentationEqualityComparerFactory> namedMock)
        {
            Sut = sut;

            IndexedAndNamedMock = indexedAndNamedMock;
            IndexedMock = indexedMock;
            NamedMock = namedMock;
        }

        ITypeParameterRepresentationEqualityComparerFactoryProvider IProviderFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.IndexedAndNamedMock => IndexedAndNamedMock;
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.IndexedMock => IndexedMock;
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> IProviderFixture.NamedMock => NamedMock;
    }
}
