namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

internal interface IFixture<TResponse>
{
    public abstract IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> Sut { get; }

    public abstract Mock<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>> DelegatingCoordinatorMock { get; }
}
