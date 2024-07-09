namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

using Moq;

internal static class FixtureFactory
{
    public static IFixture Create(int ordinal, string name)
    {
        Mock<IGetTypeParameterRepresentationByOrdinalAndNameQuery> queryMock = new();

        queryMock.Setup((query) => query.Ordinal).Returns(ordinal);
        queryMock.Setup((query) => query.Name).Returns(name);

        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> factory = new TypeParameterRepresentationWithOrdinalAndNameFactory();

        var sut = factory.Handle(queryMock.Object);

        return new Fixture(sut, ordinal, name);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly ITypeParameterRepresentation Sut;

        private readonly int Ordinal;
        private readonly string Name;

        public Fixture(
            ITypeParameterRepresentation sut,
            int ordinal,
            string name)
        {
            Sut = sut;

            Ordinal = ordinal;
            Name = name;
        }

        ITypeParameterRepresentation IFixture.Sut => Sut;

        int IFixture.Ordinal => Ordinal;
        string IFixture.Name => Name;
    }
}
