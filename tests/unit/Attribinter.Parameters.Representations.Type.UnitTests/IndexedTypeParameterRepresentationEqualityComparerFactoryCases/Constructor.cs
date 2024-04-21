namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static IndexedTypeParameterRepresentationEqualityComparerFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
