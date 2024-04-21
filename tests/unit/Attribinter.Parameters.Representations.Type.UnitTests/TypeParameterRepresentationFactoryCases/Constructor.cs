namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    private static TypeParameterRepresentationFactory Target(ITypeParameterRepresentationFactoryProvider factoryProvider) => new(factoryProvider);

    [Fact]
    public void NullFactoryProvider_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidFactoryProvider_ReturnsFactory()
    {
        var result = Target(Mock.Of<ITypeParameterRepresentationFactoryProvider>());

        Assert.NotNull(result);
    }
}
