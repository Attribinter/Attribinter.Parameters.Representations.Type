namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

using System;

using Xunit;

public sealed class GetIndex
{
    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = RepresentationFixtureFactory.Create(string.Empty);

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }

    private static int Target(
        IRepresentationFixture fixture)
    {
        return fixture.Sut.GetIndex();
    }
}
