namespace Paraminter.Parameters.Representations.Type;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

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
        private readonly IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> Sut;

        public Fixture(
            IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> IFixture.Sut => Sut;
    }
}
