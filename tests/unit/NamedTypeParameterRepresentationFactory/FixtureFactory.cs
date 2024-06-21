namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        NamedTypeParameterRepresentationFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedTypeParameterRepresentationFactory Sut;

        public Fixture(
            INamedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        INamedTypeParameterRepresentationFactory IFixture.Sut => Sut;
    }
}
