namespace Paraminter.Parameters.Representations;

using Moq;

using System;
using System.Linq.Expressions;

using Xunit;

public sealed class Handle
{
    [Fact]
    public void ValidArguments_HandlesQuery()
    {
        var fixture = FixtureFactory.Create<object>();

        var ordinal = 42;

        var response = Mock.Of<object>();

        fixture.DelegatingCoordinatorMock.Setup(CoordinatorExpression<object>(ordinal)).Returns(response);

        var result = Target(fixture, ordinal);

        Assert.Same(response, result);

        fixture.DelegatingCoordinatorMock.Verify(CoordinatorExpression<object>(ordinal), Times.Once);
    }

    private static Expression<Func<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory>, TResponse>> CoordinatorExpression<TResponse>(
        int ordinal)
    {
        return (coordinator) => coordinator.Handle(It.Is(MatchQueryCreationDelegate(ordinal)));
    }

    private static Expression<Func<DCreateQuery<IGetTypeParameterRepresentationByOrdinalQuery, IGetTypeParameterRepresentationByOrdinalQueryFactory>, bool>> MatchQueryCreationDelegate(
        int ordinal)
    {
        return (queryCreationDelegate) => VerifyQueryCreationDelegate(queryCreationDelegate, ordinal);
    }

    private static bool VerifyQueryCreationDelegate(
        DCreateQuery<IGetTypeParameterRepresentationByOrdinalQuery, IGetTypeParameterRepresentationByOrdinalQueryFactory> queryCreationDelegate,
        int ordinal)
    {
        var query = Mock.Of<IGetTypeParameterRepresentationByOrdinalQuery>();

        Mock<IGetTypeParameterRepresentationByOrdinalQueryFactory> queryFactoryMock = new();

        queryFactoryMock.Setup((factory) => factory.Create(ordinal)).Returns(query);

        var result = queryCreationDelegate(queryFactoryMock.Object);

        return ReferenceEquals(result, query);
    }

    private static TResponse Target<TResponse>(
        IFixture<TResponse> fixture,
        int ordinal)
    {
        return fixture.Sut.Handle(ordinal);
    }
}
