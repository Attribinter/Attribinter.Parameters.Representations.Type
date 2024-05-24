namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class Equals
{
    private readonly IComparerFixture Fixture = ComparerFixtureFactory.Create();

    [Fact]
    public void NullX_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullY_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<ITypeParameterRepresentation>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void XWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();

        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var result = Record.Exception(() => Target(xMock.Object, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void YWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var result = Record.Exception(() => Target(xMock.Object, yMock.Object));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void FalseReturningNameComparer_ReturnsFalse() => PropagatesReturnValue(false);

    [Fact]
    public void TrueReturningNameComparer_ReturnsTrue() => PropagatesReturnValue(true);

    [AssertionMethod]
    private void PropagatesReturnValue(bool returnValue)
    {
        var xName = "NameX";
        var yName = "NameY";

        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        xMock.Setup(static (representation) => representation.GetName()).Returns(xName);

        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        yMock.Setup(static (representation) => representation.GetName()).Returns(yName);

        Fixture.NameComparerMock.Setup((comparer) => comparer.Equals(xName, yName)).Returns(returnValue);

        var result = Target(xMock.Object, yMock.Object);

        Assert.Equal(returnValue, result);
    }

    private bool Target(ITypeParameterRepresentation x, ITypeParameterRepresentation y) => Fixture.Sut.Equals(x, y);
}
