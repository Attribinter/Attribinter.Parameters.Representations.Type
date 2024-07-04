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
        var result = Target(Mock.Of<ITypeParameterRepresentationWithOrdinalFactory>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByOrdinalQueryHandler Target(
        ITypeParameterRepresentationWithOrdinalFactory typeParameterRepresentationFactory)
    {
        return new GetTypeParameterRepresentationByOrdinalQueryHandler(typeParameterRepresentationFactory);
    }
}
