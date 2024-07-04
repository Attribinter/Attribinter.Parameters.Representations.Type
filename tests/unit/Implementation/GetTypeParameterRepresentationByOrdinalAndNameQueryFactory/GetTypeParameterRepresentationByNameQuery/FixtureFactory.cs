namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal, string name)
    {
        IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory factory = new GetTypeParameterRepresentationByOrdinalAndNameQueryFactory();

        var sut = factory.Create(ordinal, name);

        return new Fixture(sut, ordinal, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByOrdinalAndNameQuery Sut;

        private readonly int Ordinal;
        private readonly string Name;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalAndNameQuery sut,
            int ordinal,
            string name)
        {
            Sut = sut;

            Ordinal = ordinal;
            Name = name;
        }

        IGetTypeParameterRepresentationByOrdinalAndNameQuery IFixture.Sut => Sut;

        int IFixture.Ordinal => Ordinal;
        string IFixture.Name => Name;
    }
}
