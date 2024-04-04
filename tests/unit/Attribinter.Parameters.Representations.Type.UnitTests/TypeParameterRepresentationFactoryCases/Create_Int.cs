namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using Xunit;

public sealed class Create_Int
{
    private ITypeParameterRepresentation Target(int index) => Context.Factory.Create(index);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsRepresentation()
    {
        var index = 42;

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Context.FactoryProviderMock.Setup(static (provider) => provider.IndexedFactory.Create(It.IsAny<int>())).Returns(representation);

        var actual = Target(index);

        Assert.Equal(representation, actual);

        Context.FactoryProviderMock.Verify((provider) => provider.IndexedFactory.Create(index), Times.Once());
        Context.FactoryProviderMock.VerifyNoOtherCalls();
    }
}
