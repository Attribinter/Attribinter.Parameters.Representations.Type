namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    private static bool Target(ITypeParameterRepresentation representation) => representation.IsNameKnown;

    [Fact]
    public void ReturnsTrue()
    {
        var context = RepresentationContext.Create(0, string.Empty);

        var actual = Target(context.Representation);

        Assert.True(actual);
    }
}
