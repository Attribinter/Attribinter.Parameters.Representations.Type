namespace Paraminter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidParameter_ReturnsRepresentation()
    {
        var representation = Mock.Of<ITypeParameterRepresentation>();

        var index = 42;
        var name = "Name";

        Mock<ITypeParameter> parameterMock = new();

        parameterMock.Setup(static (parameter) => parameter.Symbol.Ordinal).Returns(index);
        parameterMock.Setup(static (parameter) => parameter.Symbol.Name).Returns(name);

        Fixture.InnerFactoryMock.Setup((factory) => factory.Create(index, name)).Returns(representation);

        var result = Target(parameterMock.Object);

        Assert.Same(representation, result);
    }

    private ITypeParameterRepresentation Target(
        ITypeParameter parameter)
    {
        return Fixture.Sut.Create(parameter);
    }
}
