namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        IGetTypeParameterRepresentationByNameQueryFactory factory = new GetTypeParameterRepresentationByNameQueryFactory();

        var sut = factory.Create(name);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByNameQuery Sut;

        private readonly string Name;

        public Fixture(
            IGetTypeParameterRepresentationByNameQuery sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        IGetTypeParameterRepresentationByNameQuery IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}
