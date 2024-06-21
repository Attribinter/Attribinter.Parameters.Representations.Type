namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationFactory> InnerFactoryMock { get; }
}
