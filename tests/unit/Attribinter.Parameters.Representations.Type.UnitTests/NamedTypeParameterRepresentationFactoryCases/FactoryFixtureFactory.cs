namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases;

internal static class FactoryFixtureFactory
{
    public static IFactoryFixture Create()
    {
        NamedTypeParameterRepresentationFactory sut = new();

        return new FactoryFixture(sut);
    }

    private sealed class FactoryFixture : IFactoryFixture
    {
        private readonly INamedTypeParameterRepresentationFactory Sut;

        public FactoryFixture(INamedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        INamedTypeParameterRepresentationFactory IFactoryFixture.Sut => Sut;
    }
}
