namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static IndexedTypeParameterRepresentationFactory Target() => new();
}
