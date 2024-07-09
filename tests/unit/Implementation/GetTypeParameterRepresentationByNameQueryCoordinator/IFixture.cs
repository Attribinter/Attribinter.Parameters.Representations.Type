namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> DelegatingCoordinatorMock { get; }
}
