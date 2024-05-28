namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        IndexedTypeParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture
        : IFactoryFixture
    {
        private readonly IIndexedTypeParameterRepresentationFactory Sut;

        public FactoryFixture(
            IIndexedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IIndexedTypeParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
