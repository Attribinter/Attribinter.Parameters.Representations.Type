namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class IndexedFactory
{
    private static IIndexedTypeParameterRepresentationEqualityComparerFactory Target() => Context.Provider.IndexedFactory;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target();

        Assert.Same(Context.IndexedFactory, actual);
    }
}
