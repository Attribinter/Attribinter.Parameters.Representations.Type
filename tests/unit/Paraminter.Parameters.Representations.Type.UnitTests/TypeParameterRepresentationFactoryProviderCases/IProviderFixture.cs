namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

internal interface IProviderFixture
{
    public abstract ITypeParameterRepresentationFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedFactoryMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationFactory> IndexedFactoryMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationFactory> NamedFactoryMock { get; }
}
