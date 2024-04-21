namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> factoryProviderMock = new();

        var sut = new TypeParameterRepresentationEqualityComparerFactory(factoryProviderMock.Object);

        return new FactoryFixture(sut, factoryProviderMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly ITypeParameterRepresentationEqualityComparerFactory Sut;

        private readonly Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> FactoryProviderMock;

        public FactoryFixture(ITypeParameterRepresentationEqualityComparerFactory sut, Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> factoryProviderMock)
        {
            Sut = sut;

            FactoryProviderMock = factoryProviderMock;
        }

        ITypeParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;

        Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> IFactoryFixture.FactoryProviderMock => FactoryProviderMock;
    }
}
