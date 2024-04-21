namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
