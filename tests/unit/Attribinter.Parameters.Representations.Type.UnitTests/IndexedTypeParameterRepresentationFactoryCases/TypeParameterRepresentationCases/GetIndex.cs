namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetIndex
{
    private static int Target(ITypeParameterRepresentation representation) => representation.GetIndex();

    [Fact]
    public void ReturnsIndexConstructedWith()
    {
        var expected = 42;

        var context = RepresentationContext.Create(expected);

        var actual = Target(context.Representation);

        Assert.Equal(expected, actual);
    }
}
