namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NamedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INamedTypeParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(INamedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        INamedTypeParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
