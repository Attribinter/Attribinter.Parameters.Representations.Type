namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryProviderCases;

using Xunit;

public sealed class NamedFactory
{
    private static INamedTypeParameterRepresentationFactory Target() => Context.Provider.NamedFactory;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target();

        Assert.Same(Context.NamedFactory, actual);
    }
}
