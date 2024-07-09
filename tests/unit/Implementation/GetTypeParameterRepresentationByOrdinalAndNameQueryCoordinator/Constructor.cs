namespace Paraminter.Parameters.Representations;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullDelegatingCoordinator_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target<object>(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsCoordinator()
    {
        var result = Target(Mock.Of<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, object, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory>>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse> Target<TResponse>(
        IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> delegatingCoordinator)
    {
        return new GetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse>(delegatingCoordinator);
    }
}
