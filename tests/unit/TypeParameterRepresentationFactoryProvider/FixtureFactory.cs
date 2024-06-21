namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> indexedAndNamedMock = new();
        Mock<IIndexedTypeParameterRepresentationFactory> indexedMock = new();
        Mock<INamedTypeParameterRepresentationFactory> namedMock = new();

        var sut = new TypeParameterRepresentationFactoryProvider(indexedAndNamedMock.Object, indexedMock.Object, namedMock.Object);

        return new Fixture(sut, indexedAndNamedMock, indexedMock, namedMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentationFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedMock;
        private readonly Mock<IIndexedTypeParameterRepresentationFactory> IndexedMock;
        private readonly Mock<INamedTypeParameterRepresentationFactory> NamedMock;

        public Fixture(
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

        ITypeParameterRepresentationFactoryProvider IFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IFixture.IndexedAndNamedMock => IndexedAndNamedMock;
        Mock<IIndexedTypeParameterRepresentationFactory> IFixture.IndexedMock => IndexedMock;
        Mock<INamedTypeParameterRepresentationFactory> IFixture.NamedMock => NamedMock;
    }
}
