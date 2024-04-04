namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class Equals
{
    private bool Target(ITypeParameterRepresentation x, ITypeParameterRepresentation y) => Context.Comparer.Equals(x, y);

    private readonly ComparerContext Context = ComparerContext.Create();

    [Fact]
    public void NullX_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void NullY_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(Mock.Of<ITypeParameterRepresentation>(), null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void XWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();

        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void YWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, yMock.Object));

        Assert.IsType<ArgumentException>(exception);
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

        Context.NameComparerMock.Setup(static (comparer) => comparer.Equals(It.IsAny<string>(), It.IsAny<string>())).Returns(returnValue);

        var actual = Target(xMock.Object, yMock.Object);

        Assert.Equal(returnValue, actual);

        Context.NameComparerMock.Verify((comparer) => comparer.Equals(xName, yName), Times.Once());
    }
}
