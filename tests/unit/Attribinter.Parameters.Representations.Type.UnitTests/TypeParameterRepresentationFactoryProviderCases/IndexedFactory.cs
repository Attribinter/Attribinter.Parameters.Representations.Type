namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class IndexedFactory
{
    private static IIndexedTypeParameterRepresentationFactory Target() => Context.Provider.IndexedFactory;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target();

        Assert.Same(Context.IndexedFactory, actual);
    }
}
