namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

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
    public void WithoutName_ThrowsArgumentException()
    {
        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(false);

        var exception = Record.Exception(() => Target(objMock.Object));

        Assert.IsType<ArgumentException>(exception);
    }

    [Fact]
    public void PropagatesHashCode()
    {
        var hashCode = 42;
        var name = "Name";

        Mock<ITypeParameterRepresentation> objMock = new();

        objMock.Setup(static (representation) => representation.IsNameKnown).Returns(true);
        objMock.Setup(static (representation) => representation.GetName()).Returns(name);

        Context.NameComparerMock.Setup(static (comparer) => comparer.GetHashCode(It.IsAny<string>())).Returns(hashCode);

        var actual = Target(objMock.Object);

        Assert.Equal(hashCode, actual);

        Context.NameComparerMock.Verify((comparer) => comparer.GetHashCode(name), Times.Once());
    }
}
