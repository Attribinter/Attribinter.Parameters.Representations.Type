namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        TypeParameterRepresentationWithOrdinalAndNameFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentationWithOrdinalAndNameFactory Sut;

        public Fixture(
            ITypeParameterRepresentationWithOrdinalAndNameFactory sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentationWithOrdinalAndNameFactory IFixture.Sut => Sut;
    }
}
