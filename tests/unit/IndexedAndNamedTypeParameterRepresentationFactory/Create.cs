namespace Paraminter.Parameters.Representations;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(0, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidIndexAndName_ReturnsRepresentation()
    {
        var result = Target(0, string.Empty);

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        int index,
        string name)
    {
        return Fixture.Sut.Create(index, name);
    }
}
