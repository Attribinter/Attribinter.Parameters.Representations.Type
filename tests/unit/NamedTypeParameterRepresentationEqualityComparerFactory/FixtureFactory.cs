namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        NamedTypeParameterRepresentationEqualityComparerFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly INamedTypeParameterRepresentationEqualityComparerFactory Sut;

        public Fixture(
            INamedTypeParameterRepresentationEqualityComparerFactory sut)
        {
            Sut = sut;
        }

        INamedTypeParameterRepresentationEqualityComparerFactory IFixture.Sut => Sut;
    }
}
