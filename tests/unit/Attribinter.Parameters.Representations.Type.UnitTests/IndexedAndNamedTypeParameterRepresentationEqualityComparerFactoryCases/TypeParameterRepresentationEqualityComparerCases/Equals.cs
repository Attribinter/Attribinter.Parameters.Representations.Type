namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

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
    public void XWithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void XWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void YWithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);

        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, yMock.Object));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void YWithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);

        yMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(xMock.Object, yMock.Object));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void DifferentIndices_ReturnsFalse()
    {
        var xIndex = 41;
        var yIndex = 42;

        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        xMock.Setup(static (representation) => representation.GetIndex()).Returns(xIndex);

        yMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        yMock.Setup(static (representation) => representation.GetIndex()).Returns(yIndex);

        Context.NameComparerMock.Setup(static (comparer) => comparer.Equals(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

        var actual = Target(xMock.Object, yMock.Object);

        Assert.True(actual);
    }

    [Fact]
    public void FalseReturningNameComparer_ReturnsFalse() => SameIndices_PropagatesReturnValue(false);

    [Fact]
    public void TrueReturningNameComparer_ReturnsTrue() => SameIndices_PropagatesReturnValue(true);

    [AssertionMethod]
    private void SameIndices_PropagatesReturnValue(bool returnValue)
    {
        var index = 42;

        var xName = "NameX";
        var yName = "NameY";

        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        xMock.Setup(static (representation) => representation.GetIndex()).Returns(index);
        xMock.Setup(static (representation) => representation.GetName()).Returns(xName);

        yMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        yMock.Setup(static (representation) => representation.GetIndex()).Returns(index);
        yMock.Setup(static (representation) => representation.GetName()).Returns(yName);

        Context.NameComparerMock.Setup(static (comparer) => comparer.Equals(It.IsAny<string>(), It.IsAny<string>())).Returns(returnValue);

        var actual = Target(xMock.Object, yMock.Object);

        Assert.Equal(returnValue, actual);

        Context.NameComparerMock.Verify((comparer) => comparer.Equals(xName, yName), Times.Once());
    }
}
