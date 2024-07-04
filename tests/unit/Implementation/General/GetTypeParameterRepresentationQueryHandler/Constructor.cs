namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullByOrdinalAndNameQueryFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullByOrdinalAndNameQueryHandler_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(
            Mock.Of<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>(),
            Mock.Of<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationQueryHandler Target(
        IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory byOrdinalAndNameQueryFactory,
        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> byOrdinalAndNameQueryHandler)
    {
        return new GetTypeParameterRepresentationQueryHandler(byOrdinalAndNameQueryFactory, byOrdinalAndNameQueryHandler);
    }
}
