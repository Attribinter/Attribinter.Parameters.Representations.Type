namespace Paraminter.Parameters.Representations;

using Moq;

using System;
using System.Linq.Expressions;

using Xunit;

public sealed class Handle
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullQuery_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidQuery_ReturnsRepresentation()
    {
        var representation = Mock.Of<ITypeParameterRepresentation>();

        var ordinal = 42;
        var name = "Name";

        Mock<ITypeParameter> parameterMock = new();
        Mock<IGetParameterRepresentationQuery<ITypeParameter>> queryMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Ordinal).Returns(ordinal);
        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        queryMock.Setup(static (query) => query.Parameter).Returns(parameterMock.Object);

        var byOrdinalAndNameQueryMatcher = CreateByOrdinalAndNameQueryMatcher(ordinal, name);

        Fixture.ByOrdinalAndNameQueryHandlerMock.Setup((factory) => factory.Handle(It.Is(byOrdinalAndNameQueryMatcher))).Returns(representation);

        var result = Target(queryMock.Object);

        Assert.Same(representation, result);
    }

    private static Expression<Func<IGetTypeParameterRepresentationByOrdinalAndNameQuery, bool>> CreateByOrdinalAndNameQueryMatcher(
        int ordinal,
        string name)
    {
        return (query) => query.Ordinal == ordinal && query.Name == name;
    }

    private ITypeParameterRepresentation Target(
        IGetParameterRepresentationQuery<ITypeParameter> query)
    {
        return Fixture.Sut.Handle(query);
    }
}
