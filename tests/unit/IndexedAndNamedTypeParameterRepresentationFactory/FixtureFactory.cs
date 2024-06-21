namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        IndexedAndNamedTypeParameterRepresentationFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IIndexedAndNamedTypeParameterRepresentationFactory Sut;

        public Fixture(
            IIndexedAndNamedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IIndexedAndNamedTypeParameterRepresentationFactory IFixture.Sut => Sut;
    }
}
