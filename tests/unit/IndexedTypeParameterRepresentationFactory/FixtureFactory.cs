namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        IndexedTypeParameterRepresentationFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IIndexedTypeParameterRepresentationFactory Sut;

        public Fixture(
            IIndexedTypeParameterRepresentationFactory sut)
        {
            Sut = sut;
        }

        IIndexedTypeParameterRepresentationFactory IFixture.Sut => Sut;
    }
}
