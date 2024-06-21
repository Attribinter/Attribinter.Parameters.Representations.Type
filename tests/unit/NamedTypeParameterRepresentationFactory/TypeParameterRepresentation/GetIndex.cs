namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using System;

using Xunit;

public sealed class GetIndex
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
        return fixture.Sut.GetIndex();
    }
}
