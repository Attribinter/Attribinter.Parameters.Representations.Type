namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<ITypeParameterRepresentationWithNameFactory> typeParameterRepresentationFactoryMock = new();

        GetTypeParameterRepresentationByNameQueryHandler sut = new(typeParameterRepresentationFactoryMock.Object);

        return new Fixture(sut, typeParameterRepresentationFactoryMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> Sut;

        private readonly Mock<ITypeParameterRepresentationWithNameFactory> TypeParameterRepresentationFactoryMock;

        public Fixture(
            IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> sut,
            Mock<ITypeParameterRepresentationWithNameFactory> typeParameterRepresentationFactoryMock)
        {
            Sut = sut;

            TypeParameterRepresentationFactoryMock = typeParameterRepresentationFactoryMock;
        }

        IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<ITypeParameterRepresentationWithNameFactory> IFixture.TypeParameterRepresentationFactoryMock => TypeParameterRepresentationFactoryMock;
    }
}
