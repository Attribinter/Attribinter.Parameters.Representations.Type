﻿namespace Paraminter.Parameters.Representations;

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
        var result = Target(Mock.Of<IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, object, IGetTypeParameterRepresentationByOrdinalQueryFactory>>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse> Target<TResponse>(
        IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory> delegatingCoordinator)
    {
        return new GetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse>(delegatingCoordinator);
    }
}
