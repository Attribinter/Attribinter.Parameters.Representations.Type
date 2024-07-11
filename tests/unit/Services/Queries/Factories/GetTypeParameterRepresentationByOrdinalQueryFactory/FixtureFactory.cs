namespace Paraminter.Parameters.Representations.Type.Queries.Factories;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        GetTypeParameterRepresentationByOrdinalQueryFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IGetTypeParameterRepresentationByOrdinalQueryFactory Sut;

        public Fixture(
            IGetTypeParameterRepresentationByOrdinalQueryFactory sut)
        {
            Sut = sut;
        }

        IGetTypeParameterRepresentationByOrdinalQueryFactory IFixture.Sut => Sut;
    }
}
