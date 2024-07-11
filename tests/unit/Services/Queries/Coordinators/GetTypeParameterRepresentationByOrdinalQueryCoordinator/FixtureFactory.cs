namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

internal static class FixtureFactory
{
    public static IFixture<TResponse> Create<TResponse>()
    {
        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> delegatingCoordinatorMock = new();

        GetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> sut = new(delegatingCoordinatorMock.Object);

        return new Fixture<TResponse>(sut, delegatingCoordinatorMock);
    }

    private sealed class Fixture<TResponse>
        : IFixture<TResponse>
    {
        private readonly IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> Sut;

        private readonly Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> DelegatingCoordinatorMock;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> sut,
            Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> delegatingCoordinatorMock)
        {
            Sut = sut;

            DelegatingCoordinatorMock = delegatingCoordinatorMock;
        }

        IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> IFixture<TResponse>.Sut => Sut;

        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> IFixture<TResponse>.DelegatingCoordinatorMock => DelegatingCoordinatorMock;
    }
}
