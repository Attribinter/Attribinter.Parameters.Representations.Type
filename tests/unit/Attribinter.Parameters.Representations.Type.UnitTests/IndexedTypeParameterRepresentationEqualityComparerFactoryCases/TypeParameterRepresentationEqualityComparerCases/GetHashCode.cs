namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(ITypeParameterRepresentation obj) => Context.Comparer.GetHashCode(obj);

    private static readonly ComparerContext Context = ComparerContext.Create();

    [Fact]
    public void Null_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void WithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(false);

        var exception = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void WithIndex_0_ReturnsIntegerHashCode() => WithIndex_ReturnsIntegerHashCode(0);

    [Fact]
    public void WithIndex_42_ReturnsIntegerHashCode() => WithIndex_ReturnsIntegerHashCode(42);

    [AssertionMethod]
    private static void WithIndex_ReturnsIntegerHashCode(int index)
    {
        var expected = index.GetHashCode();

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetIndex()).Returns(index);

        var actual = Target(objMock.Object);

        Assert.Equal(expected, actual);
    }
}
