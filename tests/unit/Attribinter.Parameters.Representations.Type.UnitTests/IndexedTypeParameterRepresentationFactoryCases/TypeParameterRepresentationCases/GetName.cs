namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using System;

using Xunit;

public sealed class GetName
{
    private static string Target(ITypeParameterRepresentation representation) => representation.GetName();

    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var context = RepresentationContext.Create(0);

        var exception = Record.Exception(() => Target(context.Representation));

        Assert.IsType<InvalidOperationException>(exception);
    }
}
