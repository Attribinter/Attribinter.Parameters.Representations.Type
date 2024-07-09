namespace Paraminter.Parameters.Representations;

using Moq;

internal static class FixtureFactory
{
    public static IFixture<TResponse> Create<TResponse>()
    {
        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> delegatingCoordinatorMock = new();

        GetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> sut = new(delegatingCoordinatorMock.Object);

        return new Fixture<TResponse>(sut, delegatingCoordinatorMock);
    }

    private sealed class Fixture<TResponse>
        : IFixture<TResponse>
    {
        private readonly IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> Sut;

        private readonly Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> DelegatingCoordinatorMock;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> sut,
            Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> delegatingCoordinatorMock)
        {
            Sut = sut;

            DelegatingCoordinatorMock = delegatingCoordinatorMock;
        }

        IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> IFixture<TResponse>.Sut => Sut;

        Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> IFixture<TResponse>.DelegatingCoordinatorMock => DelegatingCoordinatorMock;
    }
}
