namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal, string name)
    {
        ITypeParameterRepresentationWithOrdinalAndNameFactory factory = new TypeParameterRepresentationWithOrdinalAndNameFactory();

        var sut = factory.Create(ordinal, name);

        return new Fixture(sut, ordinal, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        private readonly int Ordinal;
        private readonly string Name;

        public Fixture(
            ITypeParameterRepresentation sut,
            int ordinal,
            string name)
        {
            Sut = sut;

            Ordinal = ordinal;
            Name = name;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;

        int IFixture.Ordinal => Ordinal;
        string IFixture.Name => Name;
    }
}
