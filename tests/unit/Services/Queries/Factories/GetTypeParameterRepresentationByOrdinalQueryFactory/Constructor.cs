namespace Paraminter.Parameters.Representations.Type.Queries.Factories;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static GetTypeParameterRepresentationByOrdinalQueryFactory Target() => new();
}
