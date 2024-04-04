namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using System;

using Xunit;

public sealed class GetIndex
{
    private static int Target(ITypeParameterRepresentation representation) => representation.GetIndex();

    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var context = RepresentationContext.Create(string.Empty);

        var exception = Record.Exception(() => Target(context.Representation));

        Assert.IsType<InvalidOperationException>(exception);
    }
}
