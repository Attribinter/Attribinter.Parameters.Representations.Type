namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal)
    {
        ITypeParameterRepresentationWithOrdinalFactory factory = new TypeParameterRepresentationWithOrdinalFactory();

        var sut = factory.Create(ordinal);

        return new Fixture(sut, ordinal);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        private readonly int Ordinal;

        public Fixture(
            ITypeParameterRepresentation sut,
            int ordinal)
        {
            Sut = sut;

            Ordinal = ordinal;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;

        int IFixture.Ordinal => Ordinal;
    }
}
