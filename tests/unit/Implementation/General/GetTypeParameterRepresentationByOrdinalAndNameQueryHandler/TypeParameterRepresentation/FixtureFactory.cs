namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal, string name)
    {
        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Ordinal).Returns(ordinal);
        queryMock.Setup(static (query) => query.Name).Returns(name);

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> factory = new GetTypeParameterRepresentationByOrdinalAndNameQueryHandler();

        var sut = factory.Handle(queryMock.Object);

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
