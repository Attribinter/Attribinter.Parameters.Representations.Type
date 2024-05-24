namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

internal interface IProviderFixture
{
    public abstract ITypeParameterRepresentationFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationFactory> IndexedMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationFactory> NamedMock { get; }
}
