namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract ITypeParameterRepresentationFactoryProvider Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IndexedAndNamedMock { get; }
    public abstract Mock<IIndexedTypeParameterRepresentationFactory> IndexedMock { get; }
    public abstract Mock<INamedTypeParameterRepresentationFactory> NamedMock { get; }
}
