namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        TypeParameterRepresentationWithOrdinalFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentationWithOrdinalFactory Sut;

        public Fixture(
            ITypeParameterRepresentationWithOrdinalFactory sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentationWithOrdinalFactory IFixture.Sut => Sut;
    }
}
