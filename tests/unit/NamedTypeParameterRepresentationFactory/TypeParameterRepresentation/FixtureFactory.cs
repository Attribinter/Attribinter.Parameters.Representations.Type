namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        INamedTypeParameterRepresentationFactory factory = new NamedTypeParameterRepresentationFactory();

        var sut = factory.Create(name);

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        public Fixture(
            ITypeParameterRepresentation sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;
    }
}
