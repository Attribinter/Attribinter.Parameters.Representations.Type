namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal)
    {
        Mock<IGetTypeParameterRepresentationByOrdinalQuery> queryMock = new();

        queryMock.Setup(static (query) => query.Ordinal).Returns(ordinal);

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> factory = new GetTypeParameterRepresentationByOrdinalQueryHandler();

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
