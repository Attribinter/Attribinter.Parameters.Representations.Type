namespace Attribinter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private ITypeParameterRepresentation Target(ITypeParameter parameter) => Context.Factory.Create(parameter);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullParameter_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
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

        Context.InnerFactoryMock.Setup(static (factory) => factory.Create(It.IsAny<int>(), It.IsAny<string>())).Returns(representation);

        var actual = Target(parameterMock.Object);

        Assert.Same(representation, actual);

        Context.InnerFactoryMock.Verify((factory) => factory.Create(index, name), Times.Once());
        Context.InnerFactoryMock.VerifyNoOtherCalls();
    }
}
