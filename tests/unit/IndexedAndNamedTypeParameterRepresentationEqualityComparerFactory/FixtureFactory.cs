namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Sut;

        public Fixture(
            IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory IFixture.Sut => Sut;
    }
}
