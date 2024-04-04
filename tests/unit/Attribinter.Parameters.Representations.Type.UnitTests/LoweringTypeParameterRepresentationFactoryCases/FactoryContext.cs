namespace Attribinter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock = new();

        var factory = new LoweringTypeParameterRepresentationFactory(innerFactoryMock.Object);

        return new(factory, innerFactoryMock);
    }

    public IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> Factory { get; }

    public Mock<IIndexedAndNamedTypeParameterRepresentationFactory> InnerFactoryMock { get; }

    private FactoryContext(IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> factory, Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock)
    {
        Factory = factory;

        InnerFactoryMock = innerFactoryMock;
    }
}
