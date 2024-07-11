namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

internal static class FixtureFactory
{
    public static IFixture<TResponse> Create<TResponse>()
    {
        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> delegatingCoordinatorMock = new();

        GetTypeParameterRepresentationByNameQueryCoordinator<TResponse> sut = new(delegatingCoordinatorMock.Object);

        return new Fixture<TResponse>(sut, delegatingCoordinatorMock);
    }

    private sealed class Fixture<TResponse>
        : IFixture<TResponse>
    {
        private readonly IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse> Sut;

        private readonly Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> DelegatingCoordinatorMock;

        public Fixture(
            IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse> sut,
            Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> delegatingCoordinatorMock)
        {
            Sut = sut;

            DelegatingCoordinatorMock = delegatingCoordinatorMock;
        }

        IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse> IFixture<TResponse>.Sut => Sut;

        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> IFixture<TResponse>.DelegatingCoordinatorMock => DelegatingCoordinatorMock;
    }
}
