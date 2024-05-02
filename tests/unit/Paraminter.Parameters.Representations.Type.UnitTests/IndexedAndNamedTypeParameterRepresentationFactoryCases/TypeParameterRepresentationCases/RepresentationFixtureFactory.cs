namespace Paraminter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(int index, string name)
    {
        IIndexedAndNamedTypeParameterRepresentationFactory factory = new IndexedAndNamedTypeParameterRepresentationFactory();

        var sut = factory.Create(index, name);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture : IRepresentationFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        public RepresentationFixture(ITypeParameterRepresentation sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}
