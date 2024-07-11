namespace Paraminter.Parameters.Representations.Type;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static TypeParameterRepresentationWithOrdinalFactory Target() => new();
}
