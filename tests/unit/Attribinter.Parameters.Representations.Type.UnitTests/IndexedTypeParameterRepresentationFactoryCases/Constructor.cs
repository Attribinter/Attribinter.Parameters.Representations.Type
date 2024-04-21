namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static IndexedTypeParameterRepresentationFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
