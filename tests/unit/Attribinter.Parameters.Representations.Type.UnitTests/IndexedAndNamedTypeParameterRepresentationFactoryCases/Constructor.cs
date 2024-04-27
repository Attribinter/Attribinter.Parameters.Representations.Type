namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static IndexedAndNamedTypeParameterRepresentationFactory Target() => new();
}
