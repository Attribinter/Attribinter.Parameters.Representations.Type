﻿namespace Paraminter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullInnerFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidInnerFactory_ReturnsFactory()
    {
        var result = Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>());

        Assert.NotNull(result);
    }

    private static LoweringTypeParameterRepresentationFactory Target(
        IIndexedAndNamedTypeParameterRepresentationFactory innerFactory)
    {
        return new LoweringTypeParameterRepresentationFactory(innerFactory);
    }
}
