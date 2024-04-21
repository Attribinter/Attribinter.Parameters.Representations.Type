namespace Attribinter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringTypeParameterRepresentationFactory(innerFactoryMock.Object);

        return new FactoryFixture(sut, innerFactoryMock);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationFactory> InnerFactoryMock;

        public FactoryFixture(IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> sut, Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> IFactoryFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IFactoryFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
