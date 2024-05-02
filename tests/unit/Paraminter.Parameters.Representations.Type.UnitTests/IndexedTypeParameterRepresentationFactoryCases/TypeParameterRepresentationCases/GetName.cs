namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using System;

using Xunit;

public sealed class GetName
{
    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = RepresentationFixtureFactory.Create(0);

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }

    private static string Target(IRepresentationFixture fixture) => fixture.Sut.GetName();
}
