namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

internal static class ProviderFixtureFactory
{
    public static IProviderFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> indexedAndNamedMock = new();
        Mock<IIndexedTypeParameterRepresentationFactory> indexedMock = new();
        Mock<INamedTypeParameterRepresentationFactory> namedMock = new();

        var sut = new TypeParameterRepresentationFactoryProvider(indexedAndNamedMock.Object, indexedMock.Object, namedMock.Object);

        return new ProviderFixture(sut, indexedAndNamedMock, indexedMock, namedMock);
    }

    private sealed class ProviderFixture
        : IProviderFixture
    {
        private readonly ITypeParameterRepresentationFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedMock;
        private readonly Mock<IIndexedTypeParameterRepresentationFactory> IndexedMock;
        private readonly Mock<INamedTypeParameterRepresentationFactory> NamedMock;

        public ProviderFixture(
            ITypeParameterRepresentationFactoryProvider sut,
            Mock<IIndexedAndNamedTypeParameterRepresentationFactory> indexedAndNamedMock,
            Mock<IIndexedTypeParameterRepresentationFactory> indexedMock,
            Mock<INamedTypeParameterRepresentationFactory> namedMock)
        {
            Sut = sut;

            IndexedAndNamedMock = indexedAndNamedMock;
            IndexedMock = indexedMock;
            NamedMock = namedMock;
        }

        ITypeParameterRepresentationFactoryProvider IProviderFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IProviderFixture.IndexedAndNamedMock => IndexedAndNamedMock;
        Mock<IIndexedTypeParameterRepresentationFactory> IProviderFixture.IndexedMock => IndexedMock;
        Mock<INamedTypeParameterRepresentationFactory> IProviderFixture.NamedMock => NamedMock;
    }
}
