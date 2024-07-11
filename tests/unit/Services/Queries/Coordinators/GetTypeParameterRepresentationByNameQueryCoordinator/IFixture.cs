namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>> DelegatingCoordinatorMock { get; }
}
