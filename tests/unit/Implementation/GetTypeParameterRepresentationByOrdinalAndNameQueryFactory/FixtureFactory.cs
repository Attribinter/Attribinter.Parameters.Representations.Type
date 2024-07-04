namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetTypeParameterRepresentationByOrdinalAndNameQueryFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory Sut;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory sut)
        {
            Sut = sut;
        }

        IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory IFixture.Sut => Sut;
    }
}
