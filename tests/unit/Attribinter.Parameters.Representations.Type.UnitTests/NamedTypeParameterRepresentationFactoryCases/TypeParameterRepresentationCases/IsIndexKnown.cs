namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    private static bool Target(ITypeParameterRepresentation representation) => representation.IsIndexKnown;

    [Fact]
    public void ReturnsFalse()
    {
        var context = RepresentationContext.Create(string.Empty);

        var actual = Target(context.Representation);

        Assert.False(actual);
    }
}
