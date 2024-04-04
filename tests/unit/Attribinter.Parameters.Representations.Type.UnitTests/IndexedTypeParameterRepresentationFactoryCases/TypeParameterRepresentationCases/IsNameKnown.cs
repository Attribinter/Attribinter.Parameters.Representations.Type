namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsNameKnown
{
    private static bool Target(ITypeParameterRepresentation representation) => representation.IsNameKnown;

    [Fact]
    public void ReturnsFalse()
    {
        var context = RepresentationContext.Create(0);

        var actual = Target(context.Representation);

        Assert.False(actual);
    }
}
