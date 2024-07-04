namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> byOrdinalAndNameQueryFactoryMock = new();
        Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> byOrdinalAndNameQueryHandlerMock = new();

        var sut = new GetTypeParameterRepresentationQueryHandler(byOrdinalAndNameQueryFactoryMock.Object, byOrdinalAndNameQueryHandlerMock.Object);

        return new Fixture(sut, byOrdinalAndNameQueryFactoryMock, byOrdinalAndNameQueryHandlerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> Sut;

        private readonly Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> ByOrdinalAndNameQueryFactoryMock;
        private readonly Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> ByOrdinalAndNameQueryHandlerMock;

        public Fixture(
            IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> sut,
            Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> byOrdinalAndNameQueryFactoryMock,
            Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> byOrdinalAndNameQueryHandlerMock)
        {
            Sut = sut;

            ByOrdinalAndNameQueryFactoryMock = byOrdinalAndNameQueryFactoryMock;
            ByOrdinalAndNameQueryHandlerMock = byOrdinalAndNameQueryHandlerMock;
        }

        IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> IFixture.ByOrdinalAndNameQueryFactoryMock => ByOrdinalAndNameQueryFactoryMock;
        Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> IFixture.ByOrdinalAndNameQueryHandlerMock => ByOrdinalAndNameQueryHandlerMock;
    }
}
