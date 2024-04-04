namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    private static bool Target(ITypeParameterRepresentation representation) => representation.IsIndexKnown;

    [Fact]
    public void ReturnsTrue()
    {
        var context = RepresentationContext.Create(0);

        var actual = Target(context.Representation);

        Assert.True(actual);
    }
}
