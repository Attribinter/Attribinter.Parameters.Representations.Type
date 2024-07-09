namespace Paraminter.Parameters.Representations;

using Moq;

using System;
using System.Linq.Expressions;

using Xunit;

public sealed class Handle
{
    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var fixture = FixtureFactory.Create<object>();

        var result = Record.Exception(() => Target(fixture, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_HandlesQuery()
    {
        var fixture = FixtureFactory.Create<object>();

        var name = "Name";

        var response = Mock.Of<object>();

        fixture.DelegatingCoordinatorMock.Setup(CoordinatorExpression<object>(name)).Returns(response);

        var result = Target(fixture, name);

        Assert.Same(response, result);

        fixture.DelegatingCoordinatorMock.Verify(CoordinatorExpression<object>(name), Times.Once);
    }

    private static Expression<Func<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory>, TResponse>> CoordinatorExpression<TResponse>(
        string name)
    {
        return (coordinator) => coordinator.Handle(It.Is(MatchQueryCreationDelegate(name)));
    }

    private static Expression<Func<DCreateQuery<IGetTypeParameterRepresentationByNameQuery, IGetTypeParameterRepresentationByNameQueryFactory>, bool>> MatchQueryCreationDelegate(
        string name)
    {
        return (queryCreationDelegate) => VerifyQueryCreationDelegate(queryCreationDelegate, name);
    }

    private static bool VerifyQueryCreationDelegate(
        DCreateQuery<IGetTypeParameterRepresentationByNameQuery, IGetTypeParameterRepresentationByNameQueryFactory> queryCreationDelegate,
        string name)
    {
        var query = Mock.Of<IGetTypeParameterRepresentationByNameQuery>();

        Mock<IGetTypeParameterRepresentationByNameQueryFactory> queryFactoryMock = new();

        queryFactoryMock.Setup((factory) => factory.Create(name)).Returns(query);

        var result = queryCreationDelegate(queryFactoryMock.Object);

        return ReferenceEquals(result, query);
    }

    private static TResponse Target<TResponse>(
        IFixture<TResponse> fixture,
        string name)
    {
        return fixture.Sut.Handle(name);
    }
}
