namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

using System;

using Xunit;

public sealed class GetOrdinal
{
    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = FixtureFactory.Create(string.Empty);

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }

    private static int Target(
        IFixture fixture)
    {
        return fixture.Sut.GetOrdinal();
    }
}
