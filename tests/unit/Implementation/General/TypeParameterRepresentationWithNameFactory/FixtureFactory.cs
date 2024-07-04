namespace Paraminter.Parameters.Representations;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        TypeParameterRepresentationWithNameFactory sut = new();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentationWithNameFactory Sut;

        public Fixture(
            ITypeParameterRepresentationWithNameFactory sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentationWithNameFactory IFixture.Sut => Sut;
    }
}
