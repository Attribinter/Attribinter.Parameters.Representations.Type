namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    private static bool Target(ITypeParameterRepresentation representation) => representation.IsNameKnown;

    [Fact]
    public void ReturnsTrue()
    {
        var context = RepresentationContext.Create(string.Empty);

        var actual = Target(context.Representation);

        Assert.True(actual);
    }
}
