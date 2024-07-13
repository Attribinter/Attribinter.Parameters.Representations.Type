namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Queries;
using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Parameters.Type;
using Paraminter.Queries.Handlers;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> byOrdinalAndNameQueryHandlerMock = new();

        var sut = new TypeParameterRepresentationFactory(byOrdinalAndNameQueryHandlerMock.Object);

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
