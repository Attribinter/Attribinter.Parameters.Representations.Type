namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class GetHashCode
{
    private int Target(ITypeParameterRepresentation obj) => Context.Comparer.GetHashCode(obj);

    private readonly ComparerContext Context = ComparerContext.Create();

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
    public void WithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void WithIndexAndName_0_A_ReturnsTupleHashCode() => WithIndexAndName_ReturnsTupleHashCode(0, "A");

    [Fact]
    public void WithIndexAndName_42_B_ReturnsTupleHashCode() => WithIndexAndName_ReturnsTupleHashCode(42, "B");

    [AssertionMethod]
    private void WithIndexAndName_ReturnsTupleHashCode(int index, string name)
    {
        var nameHashCode = 42;

        var expected = (index, nameHashCode).GetHashCode();

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetIndex()).Returns(index);
        objMock.Setup(static (representation) => representation.GetName()).Returns(name);

        Context.NameComparerMock.Setup(static (comparer) => comparer.GetHashCode(It.IsAny<string>())).Returns(nameHashCode);

        var actual = Target(objMock.Object);

        Assert.Equal(expected, actual);

        Context.NameComparerMock.Verify((comparer) => comparer.GetHashCode(name), Times.Once());
    }
}
