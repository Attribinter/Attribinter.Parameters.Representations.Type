namespace Paraminter.Parameters.Representations;

using Moq;

using System;

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

        var byOrdinalAndNameQuery = Mock.Of<IGetTypeParameterRepresentationByOrdinalAndNameQuery>();

        Mock<ITypeParameter> parameterMock = new();
        Mock<IGetParameterRepresentationQuery<ITypeParameter>> queryMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Ordinal).Returns(ordinal);
        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        queryMock.Setup(static (query) => query.Parameter).Returns(parameterMock.Object);

        Fixture.ByOrdinalAndNameQueryFactoryMock.Setup((factory) => factory.Create(ordinal, name)).Returns(byOrdinalAndNameQuery);
        Fixture.ByOrdinalAndNameQueryHandlerMock.Setup((factory) => factory.Handle(byOrdinalAndNameQuery)).Returns(representation);

        var result = Target(queryMock.Object);

        Assert.Same(representation, result);
    }

    private ITypeParameterRepresentation Target(
        IGetParameterRepresentationQuery<ITypeParameter> query)
    {
        return Fixture.Sut.Handle(query);
    }
}
