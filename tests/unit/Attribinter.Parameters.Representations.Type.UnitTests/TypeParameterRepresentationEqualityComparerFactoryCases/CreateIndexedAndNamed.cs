namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class CreateIndexedAndNamed
{
    private IEqualityComparer<ITypeParameterRepresentation> Target(IEqualityComparer<string> nameComparer) => Context.Factory.CreateIndexedAndNamed(nameComparer);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullNameComparer_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidNameComparer_ReturnsComparer()
    {
        var nameComparer = Mock.Of<IEqualityComparer<string>>();

        var comparer = Mock.Of<IEqualityComparer<ITypeParameterRepresentation>>();

        Context.FactoryProviderMock.Setup(static (provider) => provider.IndexedAndNamedFactory.Create(It.IsAny<IEqualityComparer<string>>())).Returns(comparer);

        var actual = Target(nameComparer);

        Assert.Equal(comparer, actual);

        Context.FactoryProviderMock.Verify((provider) => provider.IndexedAndNamedFactory.Create(nameComparer), Times.Once());
        Context.FactoryProviderMock.VerifyNoOtherCalls();
    }
}
