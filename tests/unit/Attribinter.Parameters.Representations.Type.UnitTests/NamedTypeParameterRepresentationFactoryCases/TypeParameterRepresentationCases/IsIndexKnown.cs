﻿namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class IsIndexKnown
{
    [Fact]
    public void ReturnsFalse()
    {
        var fixture = RepresentationFixtureFactory.Create(string.Empty);

        var result = Target(fixture);

        Assert.False(result);
    }

    private static bool Target(IRepresentationFixture fixture) => fixture.Sut.IsIndexKnown;
}
