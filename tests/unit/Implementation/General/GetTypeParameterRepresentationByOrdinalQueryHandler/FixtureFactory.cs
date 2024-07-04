namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<ITypeParameterRepresentationWithOrdinalFactory> typeParameterRepresentationFactoryMock = new();

        GetTypeParameterRepresentationByOrdinalQueryHandler sut = new(typeParameterRepresentationFactoryMock.Object);

        return new Fixture(sut, typeParameterRepresentationFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> Sut;

        private readonly Mock<ITypeParameterRepresentationWithOrdinalFactory> TypeParameterRepresentationFactoryMock;

        public Fixture(
            IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> sut,
            Mock<ITypeParameterRepresentationWithOrdinalFactory> typeParameterRepresentationFactoryMock)
        {
            Sut = sut;

            TypeParameterRepresentationFactoryMock = typeParameterRepresentationFactoryMock;
        }

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<ITypeParameterRepresentationWithOrdinalFactory> IFixture.TypeParameterRepresentationFactoryMock => TypeParameterRepresentationFactoryMock;
    }
}
