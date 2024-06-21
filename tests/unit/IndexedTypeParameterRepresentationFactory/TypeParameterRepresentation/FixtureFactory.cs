namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

internal static class FixtureFactory
{
    public static IFixture Create(int index)
    {
        IIndexedTypeParameterRepresentationFactory factory = new IndexedTypeParameterRepresentationFactory();

        var sut = factory.Create(index);

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        public Fixture(
            ITypeParameterRepresentation sut)
        {
            Sut = sut;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;
    }
}
