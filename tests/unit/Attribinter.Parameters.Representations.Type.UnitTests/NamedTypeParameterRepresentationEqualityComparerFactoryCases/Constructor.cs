﻿namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static NamedTypeParameterRepresentationEqualityComparerFactory Target() => new();
}
