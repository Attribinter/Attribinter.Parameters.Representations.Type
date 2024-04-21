namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    private static TypeParameterRepresentationFactoryProvider Target(IIndexedAndNamedTypeParameterRepresentationFactory indexedAndNamedFactory, IIndexedTypeParameterRepresentationFactory indexedFactory, INamedTypeParameterRepresentationFactory namedFactory) => new(indexedAndNamedFactory, indexedFactory, namedFactory);

    [Fact]
    public void NullIndexedAndNamedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IIndexedTypeParameterRepresentationFactory>(), Mock.Of<INamedTypeParameterRepresentationFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullIndexedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>(), null!, Mock.Of<INamedTypeParameterRepresentationFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullNamedFactory_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>(), Mock.Of<IIndexedTypeParameterRepresentationFactory>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>(), Mock.Of<IIndexedTypeParameterRepresentationFactory>(), Mock.Of<INamedTypeParameterRepresentationFactory>());

        Assert.NotNull(result);
    }
}
