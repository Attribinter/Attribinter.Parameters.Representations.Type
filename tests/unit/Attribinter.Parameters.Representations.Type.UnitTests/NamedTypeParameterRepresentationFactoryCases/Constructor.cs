namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static NamedTypeParameterRepresentationFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
