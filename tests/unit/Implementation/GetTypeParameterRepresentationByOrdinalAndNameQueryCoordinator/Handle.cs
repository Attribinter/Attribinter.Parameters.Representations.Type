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

        var result = Record.Exception(() => Target(fixture, 42, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_HandlesQuery()
    {
        var fixture = FixtureFactory.Create<object>();

        var ordinal = 42;
        var name = "Name";

        var response = Mock.Of<object>();

        fixture.DelegatingCoordinatorMock.Setup(CoordinatorExpression<object>(ordinal, name)).Returns(response);

        var result = Target(fixture, ordinal, name);

        Assert.Same(response, result);

        fixture.DelegatingCoordinatorMock.Verify(CoordinatorExpression<object>(ordinal, name), Times.Once);
    }

    private static Expression<Func<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>, TResponse>> CoordinatorExpression<TResponse>(
        int ordinal,
        string name)
    {
        return (coordinator) => coordinator.Handle(It.Is(MatchQueryCreationDelegate(ordinal, name)));
    }

    private static Expression<Func<DCreateQuery<IGetTypeParameterRepresentationByOrdinalAndNameQuery, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>, bool>> MatchQueryCreationDelegate(
        int ordinal,
        string name)
    {
        return (queryCreationDelegate) => VerifyQueryCreationDelegate(queryCreationDelegate, ordinal, name);
    }

    private static bool VerifyQueryCreationDelegate(
        DCreateQuery<IGetTypeParameterRepresentationByOrdinalAndNameQuery, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> queryCreationDelegate,
        int ordinal,
        string name)
    {
        var query = Mock.Of<IGetTypeParameterRepresentationByOrdinalAndNameQuery>();

        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> queryFactoryMock = new();

        queryFactoryMock.Setup((factory) => factory.Create(ordinal, name)).Returns(query);

        var result = queryCreationDelegate(queryFactoryMock.Object);

        return ReferenceEquals(result, query);
    }

    private static TResponse Target<TResponse>(
        IFixture<TResponse> fixture,
        int ordinal,
        string name)
    {
        return fixture.Sut.Handle(ordinal, name);
    }
}
