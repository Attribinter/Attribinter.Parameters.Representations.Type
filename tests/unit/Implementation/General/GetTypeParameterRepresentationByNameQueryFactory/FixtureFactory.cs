namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetTypeParameterRepresentationByNameQueryFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByNameQueryFactory Sut;

        public Fixture(
            IGetTypeParameterRepresentationByNameQueryFactory sut)
        {
            Sut = sut;
        }

        IGetTypeParameterRepresentationByNameQueryFactory IFixture.Sut => Sut;
    }
}
