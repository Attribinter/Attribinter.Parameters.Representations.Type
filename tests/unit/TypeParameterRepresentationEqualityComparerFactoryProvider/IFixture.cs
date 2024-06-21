namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract ITypeParameterRepresentationEqualityComparerFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedMock { get; }
}
