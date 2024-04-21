namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        IndexedAndNamedTypeParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly IIndexedAndNamedTypeParameterRepresentationFactory Sut;

        public FactoryFixture(IIndexedAndNamedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IIndexedAndNamedTypeParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
