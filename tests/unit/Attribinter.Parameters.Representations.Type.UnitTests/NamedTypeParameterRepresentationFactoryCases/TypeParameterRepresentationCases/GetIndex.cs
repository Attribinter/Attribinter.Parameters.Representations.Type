namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using System;

using Xunit;

public sealed class GetIndex
{
    private static int Target(IRepresentationFixture fixture) => fixture.Sut.GetIndex();

    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = RepresentationFixtureFactory.Create(string.Empty);

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }
}
