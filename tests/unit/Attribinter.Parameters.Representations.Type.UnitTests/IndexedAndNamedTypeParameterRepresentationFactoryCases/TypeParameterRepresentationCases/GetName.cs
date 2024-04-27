﻿namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using Xunit;

public sealed class GetName
{
    [Fact]
    public void ReturnsNameConstructedWith()
    {
        var expected = "Name";

        var fixture = RepresentationFixtureFactory.Create(0, expected);

        var result = Target(fixture);

        Assert.Equal(expected, result);
    }

    private static string Target(IRepresentationFixture fixture) => fixture.Sut.GetName();
}
