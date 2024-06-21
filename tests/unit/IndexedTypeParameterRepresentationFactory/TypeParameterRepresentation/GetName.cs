namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using System;

using Xunit;

public sealed class GetName
{
    [Fact]
    public void ThrowsInvalidOperationException()
    {
        var fixture = FixtureFactory.Create(0);

        var result = Record.Exception(() => Target(fixture));

        Assert.IsType<InvalidOperationException>(result);
    }

    private static string Target(
        IFixture fixture)
    {
        return fixture.Sut.GetName();
    }
}
