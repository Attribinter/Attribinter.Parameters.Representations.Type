namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        ITypeParameterRepresentationWithNameFactory factory = new TypeParameterRepresentationWithNameFactory();

        var sut = factory.Create(name);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        private readonly string Name;

        public Fixture(
            ITypeParameterRepresentation sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}
