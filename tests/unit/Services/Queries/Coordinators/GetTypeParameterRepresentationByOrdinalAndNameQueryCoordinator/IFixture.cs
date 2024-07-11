namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>> DelegatingCoordinatorMock { get; }
}
