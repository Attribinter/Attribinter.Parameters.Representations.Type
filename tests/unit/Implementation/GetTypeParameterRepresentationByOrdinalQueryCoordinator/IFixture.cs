namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> DelegatingCoordinatorMock { get; }
}
