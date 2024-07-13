namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

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
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(
            Mock.Of<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static TypeParameterRepresentationFactory Target(
        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> byOrdinalAndNameQueryHandler)
    {
        return new TypeParameterRepresentationFactory(byOrdinalAndNameQueryHandler);
    }
}
