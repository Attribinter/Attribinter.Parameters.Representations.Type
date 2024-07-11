namespace Paraminter.Parameters.Representations.Type.GetTypeParameterRepresentationByNameQuery;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

internal static class FixtureFactory
{
    public static IFixture Create(string name)
    {
        Mock<IGetTypeParameterRepresentationByNameQuery> queryMock = new();

        queryMock.Setup((query) => query.Name).Returns(name);

        IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> factory = new TypeParameterRepresentationWithNameFactory();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        private readonly string Name;

        public Fixture(
            ITypeParameterRepresentation sut,
            string name)
        {
            Sut = sut;

            Name = name;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;

        string IFixture.Name => Name;
    }
}
