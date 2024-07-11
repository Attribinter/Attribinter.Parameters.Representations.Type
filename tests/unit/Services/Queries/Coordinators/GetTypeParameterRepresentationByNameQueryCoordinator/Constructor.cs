namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

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
        var result = Target(Mock.Of<IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, object, IGetTypeParameterRepresentationByNameQueryFactory>>());

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByNameQueryCoordinator<TResponse> Target<TResponse>(
        IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory> delegatingCoordinator)
    {
        return new GetTypeParameterRepresentationByNameQueryCoordinator<TResponse>(delegatingCoordinator);
    }
}
