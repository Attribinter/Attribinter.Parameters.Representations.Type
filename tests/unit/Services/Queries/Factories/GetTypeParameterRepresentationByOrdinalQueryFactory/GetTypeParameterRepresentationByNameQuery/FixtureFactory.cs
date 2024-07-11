namespace Paraminter.Parameters.Representations.Type.Queries.Factories.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal)
    {
        IGetTypeParameterRepresentationByOrdinalQueryFactory factory = new GetTypeParameterRepresentationByOrdinalQueryFactory();

        var sut = factory.Create(ordinal);

        return new Fixture(sut, ordinal);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByOrdinalQuery Sut;

        private readonly int Ordinal;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalQuery sut,
            int ordinal)
        {
            Sut = sut;

            Ordinal = ordinal;
        }

        IGetTypeParameterRepresentationByOrdinalQuery IFixture.Sut => Sut;

        int IFixture.Ordinal => Ordinal;
    }
}
