namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        IndexedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly IIndexedTypeParameterRepresentationEqualityComparerFactory Sut;

        public FactoryFixture(
            IIndexedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IIndexedTypeParameterRepresentationEqualityComparerFactory IFactoryFixture.Sut => Sut;
    }
}
