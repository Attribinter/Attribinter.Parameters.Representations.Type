namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullByOrdinalAndNameQueryHandler_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidByOrdinalAndNameQueryHandler_ReturnsFactory()
    {
        var result = Target(Mock.Of<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationQueryHandler Target(
        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> byOrdinalAndNameQueryHandler)
    {
        return new GetTypeParameterRepresentationQueryHandler(byOrdinalAndNameQueryHandler);
    }
}
