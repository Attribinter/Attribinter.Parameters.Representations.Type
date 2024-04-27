namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static IndexedTypeParameterRepresentationEqualityComparerFactory Target() => new();
}
