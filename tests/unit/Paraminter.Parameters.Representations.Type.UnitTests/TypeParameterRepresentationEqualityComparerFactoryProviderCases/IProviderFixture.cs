namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

internal interface IProviderFixture
{
    public abstract ITypeParameterRepresentationEqualityComparerFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory> IndexedAndNamedMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationEqualityComparerFactory> IndexedMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationEqualityComparerFactory> NamedMock { get; }
}
