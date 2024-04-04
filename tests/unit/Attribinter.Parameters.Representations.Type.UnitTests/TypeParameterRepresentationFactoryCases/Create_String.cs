namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create_String
{
    private ITypeParameterRepresentation Target(string name) => Context.Factory.Create(name);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidName_ReturnsRepresentation()
    {
        var name = "Name";

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Context.FactoryProviderMock.Setup(static (provider) => provider.NamedFactory.Create(It.IsAny<string>())).Returns(representation);

        var actual = Target(name);

        Assert.Equal(representation, actual);

        Context.FactoryProviderMock.Verify((provider) => provider.NamedFactory.Create(name), Times.Once());
        Context.FactoryProviderMock.VerifyNoOtherCalls();
    }
}
