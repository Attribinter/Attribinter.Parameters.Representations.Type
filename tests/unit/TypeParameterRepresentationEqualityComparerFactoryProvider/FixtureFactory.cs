namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> indexedAndNamedMock = new();
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> indexedMock = new();
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> namedMock = new();

        var sut = new TypeParameterRepresentationEqualityComparerFactoryProvider(indexedAndNamedMock.Object, indexedMock.Object, namedMock.Object);

        return new Fixture(sut, indexedAndNamedMock, indexedMock, namedMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentationEqualityComparerFactoryProvider Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedMock;
        private readonly Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedMock;
        private readonly Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedMock;

        public Fixture(
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

        ITypeParameterRepresentationEqualityComparerFactoryProvider IFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IFixture.IndexedAndNamedMock => IndexedAndNamedMock;
        Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IFixture.IndexedMock => IndexedMock;
        Mock<INamedTypeParameterRepresentationEqualityComparerFactory> IFixture.NamedMock => NamedMock;
    }
}
