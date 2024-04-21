namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationFactoryCases.TypeParameterRepresentationCases;

internal static class RepresentationFixtureFactory
{
    public static IRepresentationFixture Create(string name)
    {
        INamedTypeParameterRepresentationFactory factory = new NamedTypeParameterRepresentationFactory();

        var sut = factory.Create(name);

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
