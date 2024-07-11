namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullByOrdinalAndNameQueryCoordinator_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(
            Mock.Of<IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation>>());

        Assert.NotNull(result);
    }

    private static TypeParameterRepresentationFactory Target(
        IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation> byOrdinalAndNameQueryCoordinator)
    {
        return new TypeParameterRepresentationFactory(byOrdinalAndNameQueryCoordinator);
    }
}
