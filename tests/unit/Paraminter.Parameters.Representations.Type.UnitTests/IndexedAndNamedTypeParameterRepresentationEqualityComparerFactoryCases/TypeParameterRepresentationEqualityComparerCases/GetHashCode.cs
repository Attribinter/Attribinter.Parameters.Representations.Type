namespace Paraminter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

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
    public void WithoutIndex_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(false);

        var result = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void WithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var result = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(result);
    }

    [Fact]
    public void WithIndexAndName_0_A_ReturnsTupleHashCode() => WithIndexAndName_ReturnsTupleHashCode(0, "A");

    [Fact]
    public void WithIndexAndName_42_B_ReturnsTupleHashCode() => WithIndexAndName_ReturnsTupleHashCode(42, "B");

    [AssertionMethod]
    private void WithIndexAndName_ReturnsTupleHashCode(
        int index,
        string name)
    {
        var nameHashCode = 42;

        var expected = (index, nameHashCode).GetHashCode();

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetIndex()).Returns(index);
        objMock.Setup(static (representation) => representation.GetName()).Returns(name);

        Fixture.NameComparerMock.Setup((comparer) => comparer.GetHashCode(name)).Returns(nameHashCode);

        var result = Target(objMock.Object);

        Assert.Equal(expected, result);
    }

    private int Target(
        ITypeParameterRepresentation obj)
    {
        return Fixture.Sut.GetHashCode(obj);
    }
}
