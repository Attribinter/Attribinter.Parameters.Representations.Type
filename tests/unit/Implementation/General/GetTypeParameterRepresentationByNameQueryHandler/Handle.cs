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
        var name = "Name";
        var parameterRepresentation = Mock.Of<ITypeParameterRepresentation>();

        Mock<IGetTypeParameterRepresentationByNameQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Name).Returns(name);

        Fixture.TypeParameterRepresentationFactoryMock.Setup((factory) => factory.Create(name)).Returns(parameterRepresentation);

        var result = Target(queryMock.Object);

        Assert.Same(parameterRepresentation, result);
    }

    private ITypeParameterRepresentation Target(
        IGetTypeParameterRepresentationByNameQuery query)
    {
        return Fixture.Sut.Handle(query);
    }
}
