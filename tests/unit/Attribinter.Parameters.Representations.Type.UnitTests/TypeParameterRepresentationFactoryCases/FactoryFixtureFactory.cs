namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<ITypeParameterRepresentationFactoryProvider> factoryProviderMock = new();

        var sut = new TypeParameterRepresentationFactory(factoryProviderMock.Object);

        return new FactoryFixture(sut, factoryProviderMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly ITypeParameterRepresentationFactory Sut;

        private readonly Mock<ITypeParameterRepresentationFactoryProvider> FactoryProviderMock;

        public FactoryFixture(ITypeParameterRepresentationFactory sut, Mock<ITypeParameterRepresentationFactoryProvider> factoryProviderMock)
        {
            Sut = sut;

            FactoryProviderMock = factoryProviderMock;
        }

        ITypeParameterRepresentationFactory IFactoryFixture.Sut => Sut;

        Mock<ITypeParameterRepresentationFactoryProvider> IFactoryFixture.FactoryProviderMock => FactoryProviderMock;
    }
}
