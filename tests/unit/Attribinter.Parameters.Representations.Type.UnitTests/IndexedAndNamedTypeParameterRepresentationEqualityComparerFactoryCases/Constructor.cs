namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
