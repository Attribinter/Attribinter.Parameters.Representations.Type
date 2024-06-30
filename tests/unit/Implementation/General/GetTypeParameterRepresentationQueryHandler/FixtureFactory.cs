namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> byOrdinalAndNameQueryHandlerMock = new();

        var sut = new GetTypeParameterRepresentationQueryHandler(byOrdinalAndNameQueryHandlerMock.Object);

        return new Fixture(sut, byOrdinalAndNameQueryHandlerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> Sut;

        private readonly Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> ByOrdinalAndNameQueryHandlerMock;

        public Fixture(
            IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> sut,
            Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> byOrdinalAndNameQueryHandlerMock)
        {
            Sut = sut;

            ByOrdinalAndNameQueryHandlerMock = byOrdinalAndNameQueryHandlerMock;
        }

        IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> IFixture.ByOrdinalAndNameQueryHandlerMock => ByOrdinalAndNameQueryHandlerMock;
    }
}
