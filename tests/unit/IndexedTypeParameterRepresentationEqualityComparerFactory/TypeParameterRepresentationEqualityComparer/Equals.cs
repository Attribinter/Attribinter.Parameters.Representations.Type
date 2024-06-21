namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparer;

using Moq;

using System;

using Xunit;

public sealed class Equals
{
    private readonly IFixture Fixture = FixtureFactory.Create();

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
    public void XWithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(false);

        var result = Record.Exception(() => Target(xMock.Object, Mock.Of<ITypeParameterRepresentation>()));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void YWithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        yMock.Setup(static (representation) => representation.IsIndexKnown).Returns(false);

        var result = Record.Exception(() => Target(xMock.Object, yMock.Object));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void SameIndices_ReturnsTrue() => WithIndices_ReturnsIntegerEquality(42, 42);

    [Fact]
    public void DifferentIndices_ReturnsFalse() => WithIndices_ReturnsIntegerEquality(41, 42);

    private void WithIndices_ReturnsIntegerEquality(
        int xIndex,
        int yIndex)
    {
        var expected = xIndex == yIndex;

        Mock<ITypeParameterRepresentation> xMock = new();
        Mock<ITypeParameterRepresentation> yMock = new();

        xMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        xMock.Setup(static (representation) => representation.GetIndex()).Returns(xIndex);

        yMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        yMock.Setup(static (representation) => representation.GetIndex()).Returns(yIndex);

        var result = Target(xMock.Object, yMock.Object);

        Assert.Equal(expected, result);
    }

    private bool Target(
        ITypeParameterRepresentation x,
        ITypeParameterRepresentation y)
    {
        return Fixture.Sut.Equals(x, y);
    }
}
