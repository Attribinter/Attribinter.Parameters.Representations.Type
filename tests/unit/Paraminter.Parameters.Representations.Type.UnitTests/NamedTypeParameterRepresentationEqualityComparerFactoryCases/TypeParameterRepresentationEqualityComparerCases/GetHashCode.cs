﻿namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class GetHashCode
{
    private readonly IComparerFixture Fixture = ComparerFixtureFactory.Create();

    [Fact]
    public void Null_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void WithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var result = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void PropagatesHashCode()
    {
        var hashCode = 42;
        var name = "Name";

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetName()).Returns(name);

        Fixture.NameComparerMock.Setup((comparer) => comparer.GetHashCode(name)).Returns(hashCode);

        var result = Target(objMock.Object);

        Assert.Equal(hashCode, result);
    }

    private int Target(ITypeParameterRepresentation obj) => Fixture.Sut.GetHashCode(obj);
}
