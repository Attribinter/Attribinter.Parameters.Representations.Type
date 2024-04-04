namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class NamedFactory
{
    private static INamedTypeParameterRepresentationEqualityComparerFactory Target() => Context.Provider.NamedFactory;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target();

        Assert.Same(Context.NamedFactory, actual);
    }
}
