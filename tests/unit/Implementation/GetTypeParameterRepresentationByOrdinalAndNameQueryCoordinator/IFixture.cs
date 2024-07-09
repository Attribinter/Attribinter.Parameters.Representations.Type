namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> DelegatingCoordinatorMock { get; }
}
