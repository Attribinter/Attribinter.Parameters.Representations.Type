namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetName
{
    private static string Target(ITypeParameterRepresentation representation) => representation.GetName();

    [Fact]
    public void ReturnsNameConstructedWith()
    {
        var expected = "Name";

        var context = RepresentationContext.Create(expected);

        var actual = Target(context.Representation);

        Assert.Equal(expected, actual);
    }
}
