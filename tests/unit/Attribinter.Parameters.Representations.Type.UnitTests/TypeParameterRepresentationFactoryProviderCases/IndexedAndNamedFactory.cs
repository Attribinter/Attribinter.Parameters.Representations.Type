namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamedFactory
{
    private static IIndexedAndNamedTypeParameterRepresentationFactory Target() => Context.Provider.IndexedAndNamedFactory;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target();

        Assert.Same(Context.IndexedAndNamedFactory, actual);
    }
}
