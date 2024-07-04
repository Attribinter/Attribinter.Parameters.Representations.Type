namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullTypeParameterRepresentationFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(Mock.Of<ITypeParameterRepresentationWithOrdinalAndNameFactory>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByOrdinalAndNameQueryHandler Target(
        ITypeParameterRepresentationWithOrdinalAndNameFactory typeParameterRepresentationFactory)
    {
        return new GetTypeParameterRepresentationByOrdinalAndNameQueryHandler(typeParameterRepresentationFactory);
    }
}
