namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<ITypeParameterRepresentationWithOrdinalAndNameFactory> typeParameterRepresentationFactoryMock = new();

        GetTypeParameterRepresentationByOrdinalAndNameQueryHandler sut = new(typeParameterRepresentationFactoryMock.Object);

        return new Fixture(sut, typeParameterRepresentationFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> Sut;

        private readonly Mock<ITypeParameterRepresentationWithOrdinalAndNameFactory> TypeParameterRepresentationFactoryMock;

        public Fixture(
            IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> sut,
            Mock<ITypeParameterRepresentationWithOrdinalAndNameFactory> typeParameterRepresentationFactoryMock)
        {
            Sut = sut;

            TypeParameterRepresentationFactoryMock = typeParameterRepresentationFactoryMock;
        }

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<ITypeParameterRepresentationWithOrdinalAndNameFactory> IFixture.TypeParameterRepresentationFactoryMock => TypeParameterRepresentationFactoryMock;
    }
}
