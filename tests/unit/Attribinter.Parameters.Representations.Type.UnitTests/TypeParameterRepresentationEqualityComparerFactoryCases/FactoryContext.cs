namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> factoryProviderMock = new();

        var factory = new TypeParameterRepresentationEqualityComparerFactory(factoryProviderMock.Object);

        return new(factory, factoryProviderMock);
    }

    public ITypeParameterRepresentationEqualityComparerFactory Factory { get; }

    public Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> FactoryProviderMock { get; }

    private FactoryContext(ITypeParameterRepresentationEqualityComparerFactory factory, Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> factoryProviderMock)
    {
        Factory = factory;

        FactoryProviderMock = factoryProviderMock;
    }
}
