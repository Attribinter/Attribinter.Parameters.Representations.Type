﻿namespace Paraminter.Parameters.Representations;

using System;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidName_ReturnsRepresentation()
    {
        var result = Target("Name");

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        string name)
    {
        return Fixture.Sut.Create(name);
    }
}
