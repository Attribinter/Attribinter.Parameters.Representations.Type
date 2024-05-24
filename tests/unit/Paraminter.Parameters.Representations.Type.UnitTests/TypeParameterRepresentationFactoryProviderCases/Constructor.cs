namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullIndexedAndNamed_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IIndexedTypeParameterRepresentationFactory>(), Mock.Of<INamedTypeParameterRepresentationFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullIndexed_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<IIndexedAndNamedTypeParameterRepresentationFactory>(), null!, Mock.Of<INamedTypeParameterRepresentationFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullNamed_ThrowsArgumentNullException()
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

    private static TypeParameterRepresentationFactoryProvider Target(IIndexedAndNamedTypeParameterRepresentationFactory indexedAndNamed, IIndexedTypeParameterRepresentationFactory indexed, INamedTypeParameterRepresentationFactory named) => new(indexedAndNamed, indexed, named);
}
