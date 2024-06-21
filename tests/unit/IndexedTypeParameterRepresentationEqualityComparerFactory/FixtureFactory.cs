namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        IndexedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IIndexedTypeParameterRepresentationEqualityComparerFactory Sut;

        public Fixture(
            IIndexedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IIndexedTypeParameterRepresentationEqualityComparerFactory IFixture.Sut => Sut;
    }
}
