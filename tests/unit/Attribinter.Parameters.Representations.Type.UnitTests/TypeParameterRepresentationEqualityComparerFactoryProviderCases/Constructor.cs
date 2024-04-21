namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    private static TypeParameterRepresentationEqualityComparerFactoryProvider Target(IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationEqualityComparerFactory indexedFactory, INamedTypeParameterRepresentationEqualityComparerFactory namedFactory) => new(indexedAndNamedFactory, indexedFactory, namedFactory);

    [Fact]
    public void NullIndexedAndNamedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IIndexedTypeParameterRepresentationEqualityComparerFactory>(), Mock.Of<INamedTypeParameterRepresentationEqualityComparerFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullIndexedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>(), null!, Mock.Of<INamedTypeParameterRepresentationEqualityComparerFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullNamedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>(), Mock.Of<IIndexedTypeParameterRepresentationEqualityComparerFactory>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsProvider()
    {
        var result = Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>(), Mock.Of<IIndexedTypeParameterRepresentationEqualityComparerFactory>(), Mock.Of<INamedTypeParameterRepresentationEqualityComparerFactory>());

        Assert.NotNull(result);
    }
}
