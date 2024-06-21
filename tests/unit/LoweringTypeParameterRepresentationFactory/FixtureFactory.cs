namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock = new();

        var sut = new LoweringTypeParameterRepresentationFactory(innerFactoryMock.Object);

        return new Fixture(sut, innerFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> Sut;

        private readonly Mock<IIndexedAndNamedTypeParameterRepresentationFactory> InnerFactoryMock;

        public Fixture(
            IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> sut,
            Mock<IIndexedAndNamedTypeParameterRepresentationFactory> innerFactoryMock)
        {
            Sut = sut;

            InnerFactoryMock = innerFactoryMock;
        }

        IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<IIndexedAndNamedTypeParameterRepresentationFactory> IFixture.InnerFactoryMock => InnerFactoryMock;
    }
}
