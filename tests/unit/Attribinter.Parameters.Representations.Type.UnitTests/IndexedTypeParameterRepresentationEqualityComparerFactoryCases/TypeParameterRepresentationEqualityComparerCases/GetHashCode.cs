namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System;

using Xunit;

public sealed class GetHashCode
{
    private int Target(ITypeParameterRepresentation obj) => Fixture.Sut.GetHashCode(obj);

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
    public void WithIndex_0_ReturnsIntegerHashCode() => WithIndex_ReturnsIntegerHashCode(0);

    [Fact]
    public void WithIndex_42_ReturnsIntegerHashCode() => WithIndex_ReturnsIntegerHashCode(42);

    [AssertionMethod]
    private void WithIndex_ReturnsIntegerHashCode(int index)
    {
        var expected = index.GetHashCode();

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsIndexKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetIndex()).Returns(index);

        var result = Target(objMock.Object);

        Assert.Equal(expected, result);
    }
}
