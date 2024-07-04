namespace Paraminter.Parameters.Representations;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(42, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsRepresentation()
    {
        var result = Target(42, "Name");

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        int ordinal,
        string name)
    {
        return Fixture.Sut.Create(ordinal, name);
    }
}
