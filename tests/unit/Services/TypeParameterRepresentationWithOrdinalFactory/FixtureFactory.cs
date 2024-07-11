namespace Paraminter.Parameters.Representations.Type;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

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
        private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> Sut;

        public Fixture(
            IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> IFixture.Sut => Sut;
    }
}
