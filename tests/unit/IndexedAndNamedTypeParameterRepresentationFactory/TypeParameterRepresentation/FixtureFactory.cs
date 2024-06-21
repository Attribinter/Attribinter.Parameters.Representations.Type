namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

internal static class FixtureFactory
{
    public static IFixture Create(
        int index,
        string name)
    {
        IIndexedAndNamedTypeParameterRepresentationFactory factory = new IndexedAndNamedTypeParameterRepresentationFactory();

        var sut = factory.Create(index, name);

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
