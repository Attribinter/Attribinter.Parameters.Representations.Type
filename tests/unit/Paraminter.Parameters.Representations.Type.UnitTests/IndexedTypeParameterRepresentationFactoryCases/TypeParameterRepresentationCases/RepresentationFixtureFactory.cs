namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(int index)
    {
        IIndexedTypeParameterRepresentationFactory factory = new IndexedTypeParameterRepresentationFactory();

        var sut = factory.Create(index);

        return new RepresentationFixture(sut);
    }

    private sealed class RepresentationFixture
        : IRepresentationFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        public RepresentationFixture(
            ITypeParameterRepresentation sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentation IRepresentationFixture.Sut => Sut;
    }
}
