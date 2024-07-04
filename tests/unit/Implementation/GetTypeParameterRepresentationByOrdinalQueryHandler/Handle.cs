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
        var ordinal = 42;
        var parameterRepresentation = Mock.Of<ITypeParameterRepresentation>();

        Mock<IGetTypeParameterRepresentationByOrdinalQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Ordinal).Returns(ordinal);

        Fixture.TypeParameterRepresentationFactoryMock.Setup((factory) => factory.Create(ordinal)).Returns(parameterRepresentation);

        var result = Target(queryMock.Object);

        Assert.Same(parameterRepresentation, result);
    }

    private ITypeParameterRepresentation Target(
        IGetTypeParameterRepresentationByOrdinalQuery query)
    {
        return Fixture.Sut.Handle(query);
    }
}
