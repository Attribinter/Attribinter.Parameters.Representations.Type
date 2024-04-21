namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

internal static class ProviderFixtureFactory
{
    public static IProviderFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> indexedAndNamedFactoryMock = new();
        Mock<IIndexedTypeParameterRepresentationFactory> indexedFactoryMock = new();
        Mock<INamedTypeParameterRepresentationFactory> namedFactoryMock = new();

        var sut = new TypeParameterRepresentationFactoryProvider(indexedAndNamedFactoryMock.Object, indexedFactoryMock.Object, namedFactoryMock.Object);

        return new ProviderFixture(sut, indexedAndNamedFactoryMock, indexedFactoryMock, namedFactoryMock);
    }

    private sealed class ProviderFixture : IProviderFixture
    {
        private readonly ITypeParameterRepresentationFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedFactoryMock;
        private readonly Mock<IIndexedTypeParameterRepresentationFactory> IndexedFactoryMock;
        private readonly Mock<INamedTypeParameterRepresentationFactory> NamedFactoryMock;

        public ProviderFixture(ITypeParameterRepresentationFactoryProvider sut, Mock<IIndexedAndNamedTypeParameterRepresentationFactory> indexedAndNamedFactoryMock, Mock<IIndexedTypeParameterRepresentationFactory> indexedFactoryMock, Mock<INamedTypeParameterRepresentationFactory> namedFactoryMock)
        {
            Sut = sut;

            IndexedAndNamedFactoryMock = indexedAndNamedFactoryMock;
            IndexedFactoryMock = indexedFactoryMock;
            NamedFactoryMock = namedFactoryMock;
        }

        ITypeParameterRepresentationFactoryProvider IProviderFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IProviderFixture.IndexedAndNamedFactoryMock => IndexedAndNamedFactoryMock;
        Mock<IIndexedTypeParameterRepresentationFactory> IProviderFixture.IndexedFactoryMock => IndexedFactoryMock;
        Mock<INamedTypeParameterRepresentationFactory> IProviderFixture.NamedFactoryMock => NamedFactoryMock;
    }
}
