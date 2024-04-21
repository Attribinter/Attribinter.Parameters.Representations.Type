namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

internal interface IProviderFixture
{
    public abstract ITypeParameterRepresentationEqualityComparerFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedFactoryMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedFactoryMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedFactoryMock { get; }
}
