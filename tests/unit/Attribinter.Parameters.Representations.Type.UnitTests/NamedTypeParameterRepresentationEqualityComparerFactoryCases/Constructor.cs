namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static NamedTypeParameterRepresentationEqualityComparerFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
