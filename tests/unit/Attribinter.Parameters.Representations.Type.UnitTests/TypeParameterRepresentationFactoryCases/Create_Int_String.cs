namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create_Int_String
{
    private ITypeParameterRepresentation Target(int index, string name) => Context.Factory.Create(index, name);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(0, null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidIndexAndName_ReturnsRepresentation()
    {
        var index = 42;
        var name = "Name";

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Context.FactoryProviderMock.Setup(static (provider) => provider.IndexedAndNamedFactory.Create(It.IsAny<int>(), It.IsAny<string>())).Returns(representation);

        var actual = Target(index, name);

        Assert.Equal(representation, actual);

        Context.FactoryProviderMock.Verify((provider) => provider.IndexedAndNamedFactory.Create(index, name), Times.Once());
        Context.FactoryProviderMock.VerifyNoOtherCalls();
    }
}
