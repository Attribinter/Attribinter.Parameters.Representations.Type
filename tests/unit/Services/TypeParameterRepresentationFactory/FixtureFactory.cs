namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Queries;
using Paraminter.Parameters.Representations.Type.Queries.Coordinators;
using Paraminter.Parameters.Type;
using Paraminter.Queries.Handlers;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation>> byOrdinalAndNameQueryCoordinatorMock = new();

        var sut = new TypeParameterRepresentationFactory(byOrdinalAndNameQueryCoordinatorMock.Object);

        return new Fixture(sut, byOrdinalAndNameQueryCoordinatorMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> Sut;

        private readonly Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation>> ByOrdinalAndNameQueryCoordinatorMock;

        public Fixture(
            IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> sut,
            Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation>> byOrdinalAndNameQueryCoordinatorMock)
        {
            Sut = sut;

            ByOrdinalAndNameQueryCoordinatorMock = byOrdinalAndNameQueryCoordinatorMock;
        }

        IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation>> IFixture.ByOrdinalAndNameQueryCoordinatorMock => ByOrdinalAndNameQueryCoordinatorMock;
    }
}
