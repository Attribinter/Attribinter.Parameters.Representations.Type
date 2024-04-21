namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static IndexedAndNamedTypeParameterRepresentationFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
