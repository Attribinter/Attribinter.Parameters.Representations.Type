namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        Mock<ITypeParameterRepresentationFactoryProvider> factoryProviderMock = new();

        var factory = new TypeParameterRepresentationFactory(factoryProviderMock.Object);

        return new(factory, factoryProviderMock);
    }

    public ITypeParameterRepresentationFactory Factory { get; }

    public Mock<ITypeParameterRepresentationFactoryProvider> FactoryProviderMock { get; }

    private FactoryContext(ITypeParameterRepresentationFactory factory, Mock<ITypeParameterRepresentationFactoryProvider> factoryProviderMock)
    {
        Factory = factory;

        FactoryProviderMock = factoryProviderMock;
    }
}
